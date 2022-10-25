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
	[EntityLogicalName("msdyn_federatedarticleincident")]
	public sealed class KnowledgeFederatedArticleIncident : Entity
	{	
		public static readonly int? EntityTypeCode = 10042;
		public new const string LogicalName = "msdyn_federatedarticleincident";
		public const string PrimaryIdAttribute = "msdyn_federatedarticleincidentid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public KnowledgeFederatedArticleIncident() : base("msdyn_federatedarticleincident") { }

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
		[DisplayName("KMFederatedSearchArticleId")]
		[AttributeLogicalName("msdyn_federatedarticleid")]
		public EntityReference KMFederatedSearchArticleId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_federatedarticleid"); }
			set
			{ 
				if(value == KMFederatedSearchArticleId) return;
				SetAttributeValue("msdyn_federatedarticleid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_federatedarticleidname
        /// </summary>
		[DisplayName("msdyn_federatedarticleidname")]
		[AttributeLogicalName("msdyn_federatedarticleidname")]
		public string MsdynFederatedarticleidname
		{	
			get { return GetAttributeValue<string>("msdyn_federatedarticleidname"); }
			set
			{ 
				if(value == MsdynFederatedarticleidname) return;
				SetAttributeValue("msdyn_federatedarticleidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_federatedarticleincidentid
        /// </summary>
		[DisplayName("FederatedArticleIncidentId")]
		[AttributeLogicalName("msdyn_federatedarticleincidentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_federatedarticleincidentid", value); }
		}

							/// <summary>
        /// msdyn_incidentid
        /// </summary>
		[DisplayName("IncidentId")]
		[AttributeLogicalName("msdyn_incidentid")]
		public EntityReference IncidentId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_incidentid"); }
			set
			{ 
				if(value == IncidentId) return;
				SetAttributeValue("msdyn_incidentid", value);
			}
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
        /// msdyn_searchproviderarticleid
        /// </summary>
		[DisplayName("Search Provider Article Id")]
		[AttributeLogicalName("msdyn_searchproviderarticleid")]
		public string SearchProviderArticleId
		{	
			get { return GetAttributeValue<string>("msdyn_searchproviderarticleid"); }
			set
			{ 
				if(value == SearchProviderArticleId) return;
				SetAttributeValue("msdyn_searchproviderarticleid", value);
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
        /// 1:N Get entities for 'msdyn_federatedarticleincident_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynFederatedarticleincidentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_federatedarticleincident_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynFederatedarticleincidentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_federatedarticleincident_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynFederatedarticleincidentDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_federatedarticleincident_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynFederatedarticleincidentDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_federatedarticleincident_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynFederatedarticleincidentMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_federatedarticleincident_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynFederatedarticleincidentPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynFederatedarticleincidentProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_federatedarticleincident_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_federatedarticleincident_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_federatedarticleincident_SyncErrors")]
		public IEnumerable<SyncError> MsdynFederatedarticleincidentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_federatedarticleincident_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_federatedarticleincident_SyncErrors", null, value); }
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

			/// <summary>msdyn_federatedarticleidname</summary>
			public const string MsdynFederatedarticleidname = "msdyn_federatedarticleidname";

			/// <summary>msdyn_federatedarticleincidentid</summary>
			public const string FederatedArticleIncidentId = "msdyn_federatedarticleincidentid";

			/// <summary>msdyn_incidentid</summary>
			public const string IncidentId = "msdyn_incidentid";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_searchproviderarticleid</summary>
			public const string SearchProviderArticleId = "msdyn_searchproviderarticleid";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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
			/// <summary>1:N msdyn_federatedarticleincident_AsyncOperations</summary>
			public const string MsdynFederatedarticleincidentAsyncOperations = "msdyn_federatedarticleincident_AsyncOperations";

			/// <summary>1:N msdyn_federatedarticleincident_BulkDeleteFailures</summary>
			public const string MsdynFederatedarticleincidentBulkDeleteFailures = "msdyn_federatedarticleincident_BulkDeleteFailures";

			/// <summary>1:N msdyn_federatedarticleincident_DuplicateBaseRecord</summary>
			public const string MsdynFederatedarticleincidentDuplicateBaseRecord = "msdyn_federatedarticleincident_DuplicateBaseRecord";

			/// <summary>1:N msdyn_federatedarticleincident_DuplicateMatchingRecord</summary>
			public const string MsdynFederatedarticleincidentDuplicateMatchingRecord = "msdyn_federatedarticleincident_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_federatedarticleincident_MailboxTrackingFolders</summary>
			public const string MsdynFederatedarticleincidentMailboxTrackingFolders = "msdyn_federatedarticleincident_MailboxTrackingFolders";

			/// <summary>1:N msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynFederatedarticleincidentPrincipalObjectAttributeAccesses = "msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_federatedarticleincident_ProcessSession</summary>
			public const string MsdynFederatedarticleincidentProcessSession = "msdyn_federatedarticleincident_ProcessSession";

			/// <summary>1:N msdyn_federatedarticleincident_SyncErrors</summary>
			public const string MsdynFederatedarticleincidentSyncErrors = "msdyn_federatedarticleincident_SyncErrors";

		}
		#endregion
	}
}

