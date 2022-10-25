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
	[EntityLogicalName("uom")]
	public sealed class Unit : Entity
	{	
		public static readonly int? EntityTypeCode = 1055;
		public new const string LogicalName = "uom";
		public const string PrimaryIdAttribute = "uomid";
		public const string PrimaryNameAttribute = "name";
	
		public Unit() : base("uom") { }

		#region Attributes
		/// <summary>
        /// baseuom
        /// </summary>
		[DisplayName("Base Unit")]
		[AttributeLogicalName("baseuom")]
		public EntityReference BaseUnit
		{	
			get { return GetAttributeValue<EntityReference>("baseuom"); }
			set
			{ 
				if(value == BaseUnit) return;
				SetAttributeValue("baseuom", value);
			}
		}	
			
		/// <summary>
        /// baseuomname
        /// </summary>
		[DisplayName("baseuomname")]
		[AttributeLogicalName("baseuomname")]
		public string Baseuomname
		{	
			get { return GetAttributeValue<string>("baseuomname"); }
			set
			{ 
				if(value == Baseuomname) return;
				SetAttributeValue("baseuomname", value);
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
        /// createdbyexternalparty
        /// </summary>
		[DisplayName("Created By (External Party)")]
		[AttributeLogicalName("createdbyexternalparty")]
		public EntityReference CreatedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("createdbyexternalparty"); }
			set
			{ 
				if(value == CreatedByExternalParty) return;
				SetAttributeValue("createdbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyname
        /// </summary>
		[DisplayName("createdbyexternalpartyname")]
		[AttributeLogicalName("createdbyexternalpartyname")]
		public string Createdbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyname"); }
			set
			{ 
				if(value == Createdbyexternalpartyname) return;
				SetAttributeValue("createdbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyyominame
        /// </summary>
		[DisplayName("createdbyexternalpartyyominame")]
		[AttributeLogicalName("createdbyexternalpartyyominame")]
		public string Createdbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyyominame"); }
			set
			{ 
				if(value == Createdbyexternalpartyyominame) return;
				SetAttributeValue("createdbyexternalpartyyominame", value);
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
        /// isschedulebaseuom
        /// </summary>
		[DisplayName("Is Schedule Base Unit")]
		[AttributeLogicalName("isschedulebaseuom")]
		public bool? IsScheduleBaseUnit
		{	
			get { return GetAttributeValue<bool?>("isschedulebaseuom"); }
			set
			{ 
				if(value == IsScheduleBaseUnit) return;
				SetAttributeValue("isschedulebaseuom", value);
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
        /// modifiedbyexternalparty
        /// </summary>
		[DisplayName("Modified By (External Party)")]
		[AttributeLogicalName("modifiedbyexternalparty")]
		public EntityReference ModifiedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("modifiedbyexternalparty"); }
			set
			{ 
				if(value == ModifiedByExternalParty) return;
				SetAttributeValue("modifiedbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyname
        /// </summary>
		[DisplayName("modifiedbyexternalpartyname")]
		[AttributeLogicalName("modifiedbyexternalpartyname")]
		public string Modifiedbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyname"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyname) return;
				SetAttributeValue("modifiedbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyyominame
        /// </summary>
		[DisplayName("modifiedbyexternalpartyyominame")]
		[AttributeLogicalName("modifiedbyexternalpartyyominame")]
		public string Modifiedbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyyominame"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyyominame) return;
				SetAttributeValue("modifiedbyexternalpartyyominame", value);
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
        /// quantity
        /// </summary>
		[DisplayName("Quantity")]
		[AttributeLogicalName("quantity")]
		public decimal? Quantity
		{	
			get { return GetAttributeValue<decimal?>("quantity"); }
			set
			{ 
				if(value == Quantity) return;
				SetAttributeValue("quantity", value);
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
        /// uomid
        /// </summary>
		[DisplayName("Unit")]
		[AttributeLogicalName("uomid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("uomid", value); }
		}

							/// <summary>
        /// uomscheduleid
        /// </summary>
		[DisplayName("Unit Schedule")]
		[AttributeLogicalName("uomscheduleid")]
		public EntityReference UnitSchedule
		{	
			get { return GetAttributeValue<EntityReference>("uomscheduleid"); }
			set
			{ 
				if(value == UnitSchedule) return;
				SetAttributeValue("uomscheduleid", value);
			}
		}	
			
		/// <summary>
        /// uomscheduleidname
        /// </summary>
		[DisplayName("uomscheduleidname")]
		[AttributeLogicalName("uomscheduleidname")]
		public string Uomscheduleidname
		{	
			get { return GetAttributeValue<string>("uomscheduleidname"); }
			set
			{ 
				if(value == Uomscheduleidname) return;
				SetAttributeValue("uomscheduleidname", value);
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
        /// 1:N Get entities for 'unit_of_measurement_base_unit'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_base_unit")]
		public IEnumerable<Unit> UnitOfMeasurementBaseUnit
		{
			get { return GetRelatedEntities<Unit>("unit_of_measurement_base_unit", null); }
			set { SetRelatedEntities("unit_of_measurement_base_unit", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_contract_line_items'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_contract_line_items")]
		public IEnumerable<ContractLine> UnitOfMeasurementContractLineItems
		{
			get { return GetRelatedEntities<ContractLine>("unit_of_measurement_contract_line_items", null); }
			set { SetRelatedEntities("unit_of_measurement_contract_line_items", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_invoice_details'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_invoice_details")]
		public IEnumerable<InvoiceProduct> UnitOfMeasurementInvoiceDetails
		{
			get { return GetRelatedEntities<InvoiceProduct>("unit_of_measurement_invoice_details", null); }
			set { SetRelatedEntities("unit_of_measurement_invoice_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_opportunity_products'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_opportunity_products")]
		public IEnumerable<OpportunityProduct> UnitOfMeasurementOpportunityProducts
		{
			get { return GetRelatedEntities<OpportunityProduct>("unit_of_measurement_opportunity_products", null); }
			set { SetRelatedEntities("unit_of_measurement_opportunity_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_order_details'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_order_details")]
		public IEnumerable<OrderProduct> UnitOfMeasurementOrderDetails
		{
			get { return GetRelatedEntities<OrderProduct>("unit_of_measurement_order_details", null); }
			set { SetRelatedEntities("unit_of_measurement_order_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_product_price_levels'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_product_price_levels")]
		public IEnumerable<PriceListItem> UnitOfMeasurementProductPriceLevels
		{
			get { return GetRelatedEntities<PriceListItem>("unit_of_measurement_product_price_levels", null); }
			set { SetRelatedEntities("unit_of_measurement_product_price_levels", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_productassociation'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_productassociation")]
		public IEnumerable<ProductAssociation> UnitOfMeasurementProductassociation
		{
			get { return GetRelatedEntities<ProductAssociation>("unit_of_measurement_productassociation", null); }
			set { SetRelatedEntities("unit_of_measurement_productassociation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_products'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_products")]
		public IEnumerable<Product> UnitOfMeasurementProducts
		{
			get { return GetRelatedEntities<Product>("unit_of_measurement_products", null); }
			set { SetRelatedEntities("unit_of_measurement_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'unit_of_measurement_quote_details'
        /// </summary>
		[RelationshipSchemaName("unit_of_measurement_quote_details")]
		public IEnumerable<QuoteProduct> UnitOfMeasurementQuoteDetails
		{
			get { return GetRelatedEntities<QuoteProduct>("unit_of_measurement_quote_details", null); }
			set { SetRelatedEntities("unit_of_measurement_quote_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'UoM_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("UoM_AsyncOperations")]
		public IEnumerable<SystemJob> UoMAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("UoM_AsyncOperations", null); }
			set { SetRelatedEntities("UoM_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'UoM_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("UoM_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> UoMBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("UoM_BulkDeleteFailures", null); }
			set { SetRelatedEntities("UoM_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'uom_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("uom_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> UomMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("uom_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("uom_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'uom_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("uom_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> UomPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("uom_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("uom_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'UoM_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("UoM_SyncErrors")]
		public IEnumerable<SyncError> UoMSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("UoM_SyncErrors", null); }
			set { SetRelatedEntities("UoM_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>baseuom</summary>
			public const string BaseUnit = "baseuom";

			/// <summary>baseuomname</summary>
			public const string Baseuomname = "baseuomname";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyexternalparty</summary>
			public const string CreatedByExternalParty = "createdbyexternalparty";

			/// <summary>createdbyexternalpartyname</summary>
			public const string Createdbyexternalpartyname = "createdbyexternalpartyname";

			/// <summary>createdbyexternalpartyyominame</summary>
			public const string Createdbyexternalpartyyominame = "createdbyexternalpartyyominame";

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

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isschedulebaseuom</summary>
			public const string IsScheduleBaseUnit = "isschedulebaseuom";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyexternalparty</summary>
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";

			/// <summary>modifiedbyexternalpartyname</summary>
			public const string Modifiedbyexternalpartyname = "modifiedbyexternalpartyname";

			/// <summary>modifiedbyexternalpartyyominame</summary>
			public const string Modifiedbyexternalpartyyominame = "modifiedbyexternalpartyyominame";

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

			/// <summary>quantity</summary>
			public const string Quantity = "quantity";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>uomid</summary>
			public const string UnitId = "uomid";

			/// <summary>uomscheduleid</summary>
			public const string UnitSchedule = "uomscheduleid";

			/// <summary>uomscheduleidname</summary>
			public const string Uomscheduleidname = "uomscheduleidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N unit_of_measurement_base_unit</summary>
			public const string UnitOfMeasurementBaseUnit = "unit_of_measurement_base_unit";

			/// <summary>1:N unit_of_measurement_contract_line_items</summary>
			public const string UnitOfMeasurementContractLineItems = "unit_of_measurement_contract_line_items";

			/// <summary>1:N unit_of_measurement_invoice_details</summary>
			public const string UnitOfMeasurementInvoiceDetails = "unit_of_measurement_invoice_details";

			/// <summary>1:N unit_of_measurement_opportunity_products</summary>
			public const string UnitOfMeasurementOpportunityProducts = "unit_of_measurement_opportunity_products";

			/// <summary>1:N unit_of_measurement_order_details</summary>
			public const string UnitOfMeasurementOrderDetails = "unit_of_measurement_order_details";

			/// <summary>1:N unit_of_measurement_product_price_levels</summary>
			public const string UnitOfMeasurementProductPriceLevels = "unit_of_measurement_product_price_levels";

			/// <summary>1:N unit_of_measurement_productassociation</summary>
			public const string UnitOfMeasurementProductassociation = "unit_of_measurement_productassociation";

			/// <summary>1:N unit_of_measurement_products</summary>
			public const string UnitOfMeasurementProducts = "unit_of_measurement_products";

			/// <summary>1:N unit_of_measurement_quote_details</summary>
			public const string UnitOfMeasurementQuoteDetails = "unit_of_measurement_quote_details";

			/// <summary>1:N UoM_AsyncOperations</summary>
			public const string UoMAsyncOperations = "UoM_AsyncOperations";

			/// <summary>1:N UoM_BulkDeleteFailures</summary>
			public const string UoMBulkDeleteFailures = "UoM_BulkDeleteFailures";

			/// <summary>1:N uom_MailboxTrackingFolders</summary>
			public const string UomMailboxTrackingFolders = "uom_MailboxTrackingFolders";

			/// <summary>1:N uom_PrincipalObjectAttributeAccesses</summary>
			public const string UomPrincipalObjectAttributeAccesses = "uom_PrincipalObjectAttributeAccesses";

			/// <summary>1:N UoM_SyncErrors</summary>
			public const string UoMSyncErrors = "UoM_SyncErrors";

		}
		#endregion
	}
}

