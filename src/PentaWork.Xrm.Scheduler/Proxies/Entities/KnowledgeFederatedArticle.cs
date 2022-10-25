using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Title}")] 	
	[EntityLogicalName("msdyn_federatedarticle")]
	public sealed class KnowledgeFederatedArticle : Entity
	{	
		public static readonly int? EntityTypeCode = 10041;
		public new const string LogicalName = "msdyn_federatedarticle";
		public const string PrimaryIdAttribute = "msdyn_federatedarticleid";
		public const string PrimaryNameAttribute = "msdyn_title";
	
		public KnowledgeFederatedArticle() : base("msdyn_federatedarticle") { }

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
        /// msdyn_federatedarticleid
        /// </summary>
		[DisplayName("KM Federated Search Article")]
		[AttributeLogicalName("msdyn_federatedarticleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_federatedarticleid", value); }
		}

							/// <summary>
        /// msdyn_searchproviderarticleid
        /// </summary>
		[DisplayName("Federated Search Provider Article Id")]
		[AttributeLogicalName("msdyn_searchproviderarticleid")]
		public string FederatedSearchProviderArticleId
		{	
			get { return GetAttributeValue<string>("msdyn_searchproviderarticleid"); }
			set
			{ 
				if(value == FederatedSearchProviderArticleId) return;
				SetAttributeValue("msdyn_searchproviderarticleid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_searchproviderid
        /// </summary>
		[DisplayName("Search Provider Id")]
		[AttributeLogicalName("msdyn_searchproviderid")]
		public EntityReference SearchProviderId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_searchproviderid"); }
			set
			{ 
				if(value == SearchProviderId) return;
				SetAttributeValue("msdyn_searchproviderid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_searchprovideridname
        /// </summary>
		[DisplayName("msdyn_searchprovideridname")]
		[AttributeLogicalName("msdyn_searchprovideridname")]
		public string MsdynSearchprovideridname
		{	
			get { return GetAttributeValue<string>("msdyn_searchprovideridname"); }
			set
			{ 
				if(value == MsdynSearchprovideridname) return;
				SetAttributeValue("msdyn_searchprovideridname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_title
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("msdyn_title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("msdyn_title"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("msdyn_title", value);
			}
		}	
			
		/// <summary>
        /// msdyn_url
        /// </summary>
		[DisplayName("URL")]
		[AttributeLogicalName("msdyn_url")]
		public string URL
		{	
			get { return GetAttributeValue<string>("msdyn_url"); }
			set
			{ 
				if(value == URL) return;
				SetAttributeValue("msdyn_url", value);
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
        /// 1:N Get entities for 'msdyn_federatedarticle_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynFederatedarticleAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_federatedarticle_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynFederatedarticleBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_federatedarticle_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynFederatedarticleDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_federatedarticle_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynFederatedarticleDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_federatedarticle_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynFederatedarticleMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_federatedarticle_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId")]
		public IEnumerable<KnowledgeFederatedArticleIncident> MsdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticleIncident>("msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynFederatedarticlePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_federatedarticle_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynFederatedarticleProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_federatedarticle_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticle_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticle_SyncErrors")]
		public IEnumerable<SyncError> MsdynFederatedarticleSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_federatedarticle_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_federatedarticle_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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

			/// <summary>msdyn_federatedarticleid</summary>
			public const string KMFederatedSearchArticleId = "msdyn_federatedarticleid";

			/// <summary>msdyn_searchproviderarticleid</summary>
			public const string FederatedSearchProviderArticleId = "msdyn_searchproviderarticleid";

			/// <summary>msdyn_searchproviderid</summary>
			public const string SearchProviderId = "msdyn_searchproviderid";

			/// <summary>msdyn_searchprovideridname</summary>
			public const string MsdynSearchprovideridname = "msdyn_searchprovideridname";

			/// <summary>msdyn_title</summary>
			public const string Title = "msdyn_title";

			/// <summary>msdyn_url</summary>
			public const string URL = "msdyn_url";

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
			/// <summary>1:N msdyn_federatedarticle_AsyncOperations</summary>
			public const string MsdynFederatedarticleAsyncOperations = "msdyn_federatedarticle_AsyncOperations";

			/// <summary>1:N msdyn_federatedarticle_BulkDeleteFailures</summary>
			public const string MsdynFederatedarticleBulkDeleteFailures = "msdyn_federatedarticle_BulkDeleteFailures";

			/// <summary>1:N msdyn_federatedarticle_DuplicateBaseRecord</summary>
			public const string MsdynFederatedarticleDuplicateBaseRecord = "msdyn_federatedarticle_DuplicateBaseRecord";

			/// <summary>1:N msdyn_federatedarticle_DuplicateMatchingRecord</summary>
			public const string MsdynFederatedarticleDuplicateMatchingRecord = "msdyn_federatedarticle_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_federatedarticle_MailboxTrackingFolders</summary>
			public const string MsdynFederatedarticleMailboxTrackingFolders = "msdyn_federatedarticle_MailboxTrackingFolders";

			/// <summary>1:N msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId</summary>
			public const string MsdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId = "msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId";

			/// <summary>1:N msdyn_federatedarticle_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynFederatedarticlePrincipalObjectAttributeAccesses = "msdyn_federatedarticle_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_federatedarticle_ProcessSession</summary>
			public const string MsdynFederatedarticleProcessSession = "msdyn_federatedarticle_ProcessSession";

			/// <summary>1:N msdyn_federatedarticle_SyncErrors</summary>
			public const string MsdynFederatedarticleSyncErrors = "msdyn_federatedarticle_SyncErrors";

		}
		#endregion
	}
}

