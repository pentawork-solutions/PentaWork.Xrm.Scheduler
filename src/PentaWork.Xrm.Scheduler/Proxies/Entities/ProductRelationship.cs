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
	[EntityLogicalName("productsubstitute")]
	public sealed class ProductRelationship : Entity
	{	
		public static readonly int? EntityTypeCode = 1028;
		public new const string LogicalName = "productsubstitute";
		public const string PrimaryIdAttribute = "productsubstituteid";
		public const string PrimaryNameAttribute = "name";
	
		public ProductRelationship() : base("productsubstitute") { }

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
        /// direction
        /// </summary>
		[DisplayName("Direction")]
		[AttributeLogicalName("direction")]
		public eDirection? Direction
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("direction");
				if (optionSetValue != null) return (eDirection)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Direction) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("direction", optionSetValue); 
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
        /// productsubstituteid
        /// </summary>
		[DisplayName("Product Relationship ID")]
		[AttributeLogicalName("productsubstituteid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("productsubstituteid", value); }
		}

							/// <summary>
        /// salesrelationshiptype
        /// </summary>
		[DisplayName("Sales Relationship Type")]
		[AttributeLogicalName("salesrelationshiptype")]
		public eSalesRelationshipType? SalesRelationshipType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("salesrelationshiptype");
				if (optionSetValue != null) return (eSalesRelationshipType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SalesRelationshipType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("salesrelationshiptype", optionSetValue); 
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
        /// substitutedproductid
        /// </summary>
		[DisplayName("Related Product")]
		[AttributeLogicalName("substitutedproductid")]
		public EntityReference RelatedProduct
		{	
			get { return GetAttributeValue<EntityReference>("substitutedproductid"); }
			set
			{ 
				if(value == RelatedProduct) return;
				SetAttributeValue("substitutedproductid", value);
			}
		}	
			
		/// <summary>
        /// substitutedproductidname
        /// </summary>
		[DisplayName("substitutedproductidname")]
		[AttributeLogicalName("substitutedproductidname")]
		public string Substitutedproductidname
		{	
			get { return GetAttributeValue<string>("substitutedproductidname"); }
			set
			{ 
				if(value == Substitutedproductidname) return;
				SetAttributeValue("substitutedproductidname", value);
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
        /// 1:N Get entities for 'ProductSubstitute_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ProductSubstitute_AsyncOperations")]
		public IEnumerable<SystemJob> ProductSubstituteAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ProductSubstitute_AsyncOperations", null); }
			set { SetRelatedEntities("ProductSubstitute_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductSubstitute_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ProductSubstitute_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ProductSubstituteBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ProductSubstitute_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ProductSubstitute_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productsubstitute_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("productsubstitute_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ProductsubstituteMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("productsubstitute_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("productsubstitute_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductSubstitute_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("ProductSubstitute_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> ProductSubstitutePrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("ProductSubstitute_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("ProductSubstitute_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductSubstitute_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("ProductSubstitute_ProcessSession")]
		public IEnumerable<ProcessSession> ProductSubstituteProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("ProductSubstitute_ProcessSession", null); }
			set { SetRelatedEntities("ProductSubstitute_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductSubstitute_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ProductSubstitute_SyncErrors")]
		public IEnumerable<SyncError> ProductSubstituteSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ProductSubstitute_SyncErrors", null); }
			set { SetRelatedEntities("ProductSubstitute_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eDirection
		{	
		
			[Label("Uni-Directional")]
			[Description(@"")]
			UniDirectional = 0, 
		
			[Label("Bi-Directional")]
			[Description(@"")]
			BiDirectional = 1, 
		}
		
		public enum eSalesRelationshipType
		{	
		
			[Label("Up-sell")]
			[Description(@"")]
			Upsell = 0, 
		
			[Label("Cross-sell")]
			[Description(@"")]
			Crosssell = 1, 
		
			[Label("Accessory")]
			[Description(@"")]
			Accessory = 2, 
		
			[Label("Substitute")]
			[Description(@"")]
			Substitute = 3, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
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

			/// <summary>direction</summary>
			public const string Direction = "direction";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>productid</summary>
			public const string Product = "productid";

			/// <summary>productidname</summary>
			public const string Productidname = "productidname";

			/// <summary>productsubstituteid</summary>
			public const string ProductRelationshipId = "productsubstituteid";

			/// <summary>salesrelationshiptype</summary>
			public const string SalesRelationshipType = "salesrelationshiptype";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>substitutedproductid</summary>
			public const string RelatedProduct = "substitutedproductid";

			/// <summary>substitutedproductidname</summary>
			public const string Substitutedproductidname = "substitutedproductidname";

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
			/// <summary>1:N ProductSubstitute_AsyncOperations</summary>
			public const string ProductSubstituteAsyncOperations = "ProductSubstitute_AsyncOperations";

			/// <summary>1:N ProductSubstitute_BulkDeleteFailures</summary>
			public const string ProductSubstituteBulkDeleteFailures = "ProductSubstitute_BulkDeleteFailures";

			/// <summary>1:N productsubstitute_MailboxTrackingFolders</summary>
			public const string ProductsubstituteMailboxTrackingFolders = "productsubstitute_MailboxTrackingFolders";

			/// <summary>1:N ProductSubstitute_PrincipalObjectAttributeAccess</summary>
			public const string ProductSubstitutePrincipalObjectAttributeAccess = "ProductSubstitute_PrincipalObjectAttributeAccess";

			/// <summary>1:N ProductSubstitute_ProcessSession</summary>
			public const string ProductSubstituteProcessSession = "ProductSubstitute_ProcessSession";

			/// <summary>1:N ProductSubstitute_SyncErrors</summary>
			public const string ProductSubstituteSyncErrors = "ProductSubstitute_SyncErrors";

		}
		#endregion
	}
}

