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
	[EntityLogicalName("msdyn_kmfederatedsearchconfig")]
	public sealed class SearchProvider : Entity
	{	
		public static readonly int? EntityTypeCode = 10043;
		public new const string LogicalName = "msdyn_kmfederatedsearchconfig";
		public const string PrimaryIdAttribute = "msdyn_kmfederatedsearchconfigid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SearchProvider() : base("msdyn_kmfederatedsearchconfig") { }

		#region Attributes
		/// <summary>
        /// connectionid
        /// </summary>
		[DisplayName("Connection Id")]
		[AttributeLogicalName("connectionid")]
		public string ConnectionId
		{	
			get { return GetAttributeValue<string>("connectionid"); }
			set
			{ 
				if(value == ConnectionId) return;
				SetAttributeValue("connectionid", value);
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
        /// isdefault
        /// </summary>
		[DisplayName("Is Default")]
		[AttributeLogicalName("isdefault")]
		public bool? IsDefault
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == IsDefault) return;
				SetAttributeValue("isdefault", value);
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
        /// msdyn_description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("msdyn_description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_kmfederatedsearchconfigid
        /// </summary>
		[DisplayName("Search Provider Id")]
		[AttributeLogicalName("msdyn_kmfederatedsearchconfigid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_kmfederatedsearchconfigid", value); }
		}

							/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// organization
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organization")]
		public string Organization
		{	
			get { return GetAttributeValue<string>("organization"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organization", value);
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
        /// searchtype
        /// </summary>
		[DisplayName("Search Type")]
		[AttributeLogicalName("searchtype")]
		public eSearchType? SearchType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("searchtype");
				if (optionSetValue != null) return (eSearchType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SearchType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("searchtype", optionSetValue); 
			}
		}

		/// <summary>
        /// sharepointurl
        /// </summary>
		[DisplayName("Sharepoint URL")]
		[AttributeLogicalName("sharepointurl")]
		public string SharepointURL
		{	
			get { return GetAttributeValue<string>("sharepointurl"); }
			set
			{ 
				if(value == SharepointURL) return;
				SetAttributeValue("sharepointurl", value);
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
        /// 1:N Get entities for 'IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid'
        /// </summary>
		[RelationshipSchemaName("IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid")]
		public IEnumerable<KnowledgeFederatedArticle> IKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid", null); }
			set { SetRelatedEntities("IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynKmfederatedsearchconfigAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_kmfederatedsearchconfig_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynKmfederatedsearchconfigBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_kmfederatedsearchconfig_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynKmfederatedsearchconfigDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_kmfederatedsearchconfig_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynKmfederatedsearchconfigDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynKmfederatedsearchconfigMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_kmfederatedsearchconfig_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynKmfederatedsearchconfigProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_kmfederatedsearchconfig_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_kmfederatedsearchconfig_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_kmfederatedsearchconfig_SyncErrors")]
		public IEnumerable<SyncError> MsdynKmfederatedsearchconfigSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_kmfederatedsearchconfig_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_kmfederatedsearchconfig_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eSearchType
		{	
		
			[Label("Cross-Organizational Search")]
			[Description(@"")]
			CrossOrganizationalSearch = 100000000, 
		
			[Label("Sharepoint")]
			[Description(@"")]
			Sharepoint = 100000001, 
		
			[Label("Microsoft Search Connector")]
			[Description(@"")]
			MicrosoftSearchConnector = 100000002, 
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
			/// <summary>connectionid</summary>
			public const string ConnectionId = "connectionid";

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

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdefault</summary>
			public const string IsDefault = "isdefault";

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

			/// <summary>msdyn_description</summary>
			public const string Description = "msdyn_description";

			/// <summary>msdyn_kmfederatedsearchconfigid</summary>
			public const string SearchProviderId = "msdyn_kmfederatedsearchconfigid";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>organization</summary>
			public const string Organization = "organization";

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

			/// <summary>searchtype</summary>
			public const string SearchType = "searchtype";

			/// <summary>sharepointurl</summary>
			public const string SharepointURL = "sharepointurl";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid</summary>
			public const string IKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid = "IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_AsyncOperations</summary>
			public const string MsdynKmfederatedsearchconfigAsyncOperations = "msdyn_kmfederatedsearchconfig_AsyncOperations";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_BulkDeleteFailures</summary>
			public const string MsdynKmfederatedsearchconfigBulkDeleteFailures = "msdyn_kmfederatedsearchconfig_BulkDeleteFailures";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_DuplicateBaseRecord</summary>
			public const string MsdynKmfederatedsearchconfigDuplicateBaseRecord = "msdyn_kmfederatedsearchconfig_DuplicateBaseRecord";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord</summary>
			public const string MsdynKmfederatedsearchconfigDuplicateMatchingRecord = "msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_MailboxTrackingFolders</summary>
			public const string MsdynKmfederatedsearchconfigMailboxTrackingFolders = "msdyn_kmfederatedsearchconfig_MailboxTrackingFolders";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses = "msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_ProcessSession</summary>
			public const string MsdynKmfederatedsearchconfigProcessSession = "msdyn_kmfederatedsearchconfig_ProcessSession";

			/// <summary>1:N msdyn_kmfederatedsearchconfig_SyncErrors</summary>
			public const string MsdynKmfederatedsearchconfigSyncErrors = "msdyn_kmfederatedsearchconfig_SyncErrors";

		}
		#endregion
	}
}

