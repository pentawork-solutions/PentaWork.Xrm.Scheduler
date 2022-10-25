using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Productidname}")] 	
	[EntityLogicalName("productassociation")]
	public sealed class ProductAssociation : Entity
	{	
		public static readonly int? EntityTypeCode = 1025;
		public new const string LogicalName = "productassociation";
		public const string PrimaryIdAttribute = "productassociationid";
		public const string PrimaryNameAttribute = "productidname";
	
		public ProductAssociation() : base("productassociation") { }

		#region Attributes
		/// <summary>
        /// associatedproduct
        /// </summary>
		[DisplayName("Associated Product")]
		[AttributeLogicalName("associatedproduct")]
		public EntityReference AssociatedProduct
		{	
			get { return GetAttributeValue<EntityReference>("associatedproduct"); }
			set
			{ 
				if(value == AssociatedProduct) return;
				SetAttributeValue("associatedproduct", value);
			}
		}	
			
		/// <summary>
        /// associatedproductidname
        /// </summary>
		[DisplayName("associatedproductidname")]
		[AttributeLogicalName("associatedproductidname")]
		public string Associatedproductidname
		{	
			get { return GetAttributeValue<string>("associatedproductidname"); }
			set
			{ 
				if(value == Associatedproductidname) return;
				SetAttributeValue("associatedproductidname", value);
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
        /// productassociationid
        /// </summary>
		[DisplayName("Product Association ID")]
		[AttributeLogicalName("productassociationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("productassociationid", value); }
		}

							/// <summary>
        /// productid
        /// </summary>
		[DisplayName("Product")]
		[AttributeLogicalName("productid")]
		public EntityReference Product
		{	
			get { return GetAttributeValue<EntityReference>("productid"); }
			set
			{ 
				if(value == Product) return;
				SetAttributeValue("productid", value);
			}
		}	
			
		/// <summary>
        /// productidname
        /// </summary>
		[DisplayName("productidname")]
		[AttributeLogicalName("productidname")]
		public string Productidname
		{	
			get { return GetAttributeValue<string>("productidname"); }
			set
			{ 
				if(value == Productidname) return;
				SetAttributeValue("productidname", value);
			}
		}	
			
		/// <summary>
        /// productisrequired
        /// </summary>
		[DisplayName("Required")]
		[AttributeLogicalName("productisrequired")]
		public eIsProductRequired? Required
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("productisrequired");
				if (optionSetValue != null) return (eIsProductRequired)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Required) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("productisrequired", optionSetValue); 
			}
		}

		/// <summary>
        /// propertycustomizationstatus
        /// </summary>
		[DisplayName("Property Customization")]
		[AttributeLogicalName("propertycustomizationstatus")]
		public ePropertiesConfiguration? PropertyCustomization
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("propertycustomizationstatus");
				if (optionSetValue != null) return (ePropertiesConfiguration)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PropertyCustomization) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("propertycustomizationstatus", optionSetValue); 
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
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
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
        /// uomid
        /// </summary>
		[DisplayName("Unit")]
		[AttributeLogicalName("uomid")]
		public EntityReference Unit
		{	
			get { return GetAttributeValue<EntityReference>("uomid"); }
			set
			{ 
				if(value == Unit) return;
				SetAttributeValue("uomid", value);
			}
		}	
			
		/// <summary>
        /// uomidname
        /// </summary>
		[DisplayName("uomidname")]
		[AttributeLogicalName("uomidname")]
		public string Uomidname
		{	
			get { return GetAttributeValue<string>("uomidname"); }
			set
			{ 
				if(value == Uomidname) return;
				SetAttributeValue("uomidname", value);
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
        /// 1:N Get entities for 'ProductAssociation_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ProductAssociation_AsyncOperations")]
		public IEnumerable<SystemJob> ProductAssociationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ProductAssociation_AsyncOperations", null); }
			set { SetRelatedEntities("ProductAssociation_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productassociation_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("productassociation_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ProductassociationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("productassociation_BulkDeleteFailures", null); }
			set { SetRelatedEntities("productassociation_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductAssociation_DynamicProperty'
        /// </summary>
		[RelationshipSchemaName("ProductAssociation_DynamicProperty")]
		public IEnumerable<Property> ProductAssociationDynamicProperty
		{
			get { return GetRelatedEntities<Property>("ProductAssociation_DynamicProperty", null); }
			set { SetRelatedEntities("ProductAssociation_DynamicProperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductAssociation_DynamicPropertyAssociation'
        /// </summary>
		[RelationshipSchemaName("ProductAssociation_DynamicPropertyAssociation")]
		public IEnumerable<PropertyAssociation> ProductAssociationDynamicPropertyAssociation
		{
			get { return GetRelatedEntities<PropertyAssociation>("ProductAssociation_DynamicPropertyAssociation", null); }
			set { SetRelatedEntities("ProductAssociation_DynamicPropertyAssociation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productAssociation_invoice_details'
        /// </summary>
		[RelationshipSchemaName("productAssociation_invoice_details")]
		public IEnumerable<InvoiceProduct> ProductAssociationInvoiceDetails
		{
			get { return GetRelatedEntities<InvoiceProduct>("productAssociation_invoice_details", null); }
			set { SetRelatedEntities("productAssociation_invoice_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productassociation_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("productassociation_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ProductassociationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("productassociation_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("productassociation_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productAssociation_opportunity_product'
        /// </summary>
		[RelationshipSchemaName("productAssociation_opportunity_product")]
		public IEnumerable<OpportunityProduct> ProductAssociationOpportunityProduct
		{
			get { return GetRelatedEntities<OpportunityProduct>("productAssociation_opportunity_product", null); }
			set { SetRelatedEntities("productAssociation_opportunity_product", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductAssociation_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("ProductAssociation_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> ProductAssociationPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("ProductAssociation_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("ProductAssociation_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductAssociation_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("ProductAssociation_ProcessSessions")]
		public IEnumerable<ProcessSession> ProductAssociationProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("ProductAssociation_ProcessSessions", null); }
			set { SetRelatedEntities("ProductAssociation_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productAssociation_quote_details'
        /// </summary>
		[RelationshipSchemaName("productAssociation_quote_details")]
		public IEnumerable<QuoteProduct> ProductAssociationQuoteDetails
		{
			get { return GetRelatedEntities<QuoteProduct>("productAssociation_quote_details", null); }
			set { SetRelatedEntities("productAssociation_quote_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productAssociation_salesorder_details'
        /// </summary>
		[RelationshipSchemaName("productAssociation_salesorder_details")]
		public IEnumerable<OrderProduct> ProductAssociationSalesorderDetails
		{
			get { return GetRelatedEntities<OrderProduct>("productAssociation_salesorder_details", null); }
			set { SetRelatedEntities("productAssociation_salesorder_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductAssociation_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ProductAssociation_SyncErrors")]
		public IEnumerable<SyncError> ProductAssociationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ProductAssociation_SyncErrors", null); }
			set { SetRelatedEntities("ProductAssociation_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eIsProductRequired
		{	
		
			[Label("Optional")]
			[Description(@"")]
			Optional = 0, 
		
			[Label("Required")]
			[Description(@"")]
			Required = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 2, 
		
			[Label("Under Revision")]
			[Description(@"")]
			UnderRevision = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("DraftActive")]
			[Description(@"")]
			DraftActive = 3, 
		}
		
		public enum ePropertiesConfiguration
		{	
		
			[Label("Not Available")]
			[Description(@"")]
			NotAvailable = 0, 
		
			[Label("Available")]
			[Description(@"")]
			Available = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>associatedproduct</summary>
			public const string AssociatedProduct = "associatedproduct";

			/// <summary>associatedproductidname</summary>
			public const string Associatedproductidname = "associatedproductidname";

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

			/// <summary>productassociationid</summary>
			public const string ProductAssociationId = "productassociationid";

			/// <summary>productid</summary>
			public const string Product = "productid";

			/// <summary>productidname</summary>
			public const string Productidname = "productidname";

			/// <summary>productisrequired</summary>
			public const string Required = "productisrequired";

			/// <summary>propertycustomizationstatus</summary>
			public const string PropertyCustomization = "propertycustomizationstatus";

			/// <summary>quantity</summary>
			public const string Quantity = "quantity";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>uomid</summary>
			public const string Unit = "uomid";

			/// <summary>uomidname</summary>
			public const string Uomidname = "uomidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ProductAssociation_AsyncOperations</summary>
			public const string ProductAssociationAsyncOperations = "ProductAssociation_AsyncOperations";

			/// <summary>1:N productassociation_BulkDeleteFailures</summary>
			public const string ProductassociationBulkDeleteFailures = "productassociation_BulkDeleteFailures";

			/// <summary>1:N ProductAssociation_DynamicProperty</summary>
			public const string ProductAssociationDynamicProperty = "ProductAssociation_DynamicProperty";

			/// <summary>1:N ProductAssociation_DynamicPropertyAssociation</summary>
			public const string ProductAssociationDynamicPropertyAssociation = "ProductAssociation_DynamicPropertyAssociation";

			/// <summary>1:N productAssociation_invoice_details</summary>
			public const string ProductAssociationInvoiceDetails = "productAssociation_invoice_details";

			/// <summary>1:N productassociation_MailboxTrackingFolders</summary>
			public const string ProductassociationMailboxTrackingFolders = "productassociation_MailboxTrackingFolders";

			/// <summary>1:N productAssociation_opportunity_product</summary>
			public const string ProductAssociationOpportunityProduct = "productAssociation_opportunity_product";

			/// <summary>1:N ProductAssociation_PrincipalObjectAttributeAccess</summary>
			public const string ProductAssociationPrincipalObjectAttributeAccess = "ProductAssociation_PrincipalObjectAttributeAccess";

			/// <summary>1:N ProductAssociation_ProcessSessions</summary>
			public const string ProductAssociationProcessSessions = "ProductAssociation_ProcessSessions";

			/// <summary>1:N productAssociation_quote_details</summary>
			public const string ProductAssociationQuoteDetails = "productAssociation_quote_details";

			/// <summary>1:N productAssociation_salesorder_details</summary>
			public const string ProductAssociationSalesorderDetails = "productAssociation_salesorder_details";

			/// <summary>1:N ProductAssociation_SyncErrors</summary>
			public const string ProductAssociationSyncErrors = "ProductAssociation_SyncErrors";

		}
		#endregion
	}
}

