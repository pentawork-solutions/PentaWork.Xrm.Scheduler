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
	[EntityLogicalName("dynamicpropertyassociation")]
	public sealed class PropertyAssociation : Entity
	{	
		public static readonly int? EntityTypeCode = 1235;
		public new const string LogicalName = "dynamicpropertyassociation";
		public const string PrimaryIdAttribute = "dynamicpropertyassociationid";
		public const string PrimaryNameAttribute = "name";
	
		public PropertyAssociation() : base("dynamicpropertyassociation") { }

		#region Attributes
		/// <summary>
        /// associationstatus
        /// </summary>
		[DisplayName("Association Status.")]
		[AttributeLogicalName("associationstatus")]
		public eAssociationStatus? AssociationStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("associationstatus");
				if (optionSetValue != null) return (eAssociationStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AssociationStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("associationstatus", optionSetValue); 
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
        /// dynamicpropertyassociationid
        /// </summary>
		[DisplayName("Property Association ID")]
		[AttributeLogicalName("dynamicpropertyassociationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("dynamicpropertyassociationid", value); }
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
        /// inheritancestate
        /// </summary>
		[DisplayName("Inheritance State.")]
		[AttributeLogicalName("inheritancestate")]
		public eInheritanceState? InheritanceState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("inheritancestate");
				if (optionSetValue != null) return (eInheritanceState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InheritanceState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("inheritancestate", optionSetValue); 
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
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("regardingobjecttypecode")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string Regardingobjecttypecode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == Regardingobjecttypecode) return;
				SetAttributeValue("regardingobjecttypecode", value);
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
        /// 1:N Get entities for 'dynamicpropertyassociation_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyassociation_AsyncOperations")]
		public IEnumerable<SystemJob> DynamicpropertyassociationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("dynamicpropertyassociation_AsyncOperations", null); }
			set { SetRelatedEntities("dynamicpropertyassociation_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyassociation_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyassociation_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DynamicpropertyassociationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("dynamicpropertyassociation_BulkDeleteFailures", null); }
			set { SetRelatedEntities("dynamicpropertyassociation_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyassociation_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyassociation_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DynamicpropertyassociationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("dynamicpropertyassociation_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("dynamicpropertyassociation_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyassociation_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyassociation_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DynamicpropertyassociationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("dynamicpropertyassociation_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("dynamicpropertyassociation_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyassociation_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyassociation_SyncErrors")]
		public IEnumerable<SyncError> DynamicpropertyassociationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("dynamicpropertyassociation_SyncErrors", null); }
			set { SetRelatedEntities("dynamicpropertyassociation_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAssociationStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted = 1, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 2, 
		
			[Label("Draft Added")]
			[Description(@"")]
			DraftAdded = 3, 
		
			[Label("Draft Deleted")]
			[Description(@"")]
			DraftDeleted = 4, 
		}
		
		public enum eInheritanceState
		{	
		
			[Label("Inherited")]
			[Description(@"")]
			Inherited = 0, 
		
			[Label("Overridden")]
			[Description(@"")]
			Overridden = 1, 
		
			[Label("Owned")]
			[Description(@"")]
			Owned = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>associationstatus</summary>
			public const string AssociationStatus = "associationstatus";

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

			/// <summary>dynamicpropertyassociationid</summary>
			public const string PropertyAssociationId = "dynamicpropertyassociationid";

			/// <summary>dynamicpropertyid</summary>
			public const string PropertyID = "dynamicpropertyid";

			/// <summary>dynamicpropertyidname</summary>
			public const string Dynamicpropertyidname = "dynamicpropertyidname";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>inheritancestate</summary>
			public const string InheritanceState = "inheritancestate";

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

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

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
			/// <summary>1:N dynamicpropertyassociation_AsyncOperations</summary>
			public const string DynamicpropertyassociationAsyncOperations = "dynamicpropertyassociation_AsyncOperations";

			/// <summary>1:N dynamicpropertyassociation_BulkDeleteFailures</summary>
			public const string DynamicpropertyassociationBulkDeleteFailures = "dynamicpropertyassociation_BulkDeleteFailures";

			/// <summary>1:N dynamicpropertyassociation_MailboxTrackingFolders</summary>
			public const string DynamicpropertyassociationMailboxTrackingFolders = "dynamicpropertyassociation_MailboxTrackingFolders";

			/// <summary>1:N dynamicpropertyassociation_PrincipalObjectAttributeAccesses</summary>
			public const string DynamicpropertyassociationPrincipalObjectAttributeAccesses = "dynamicpropertyassociation_PrincipalObjectAttributeAccesses";

			/// <summary>1:N dynamicpropertyassociation_SyncErrors</summary>
			public const string DynamicpropertyassociationSyncErrors = "dynamicpropertyassociation_SyncErrors";

		}
		#endregion
	}
}

