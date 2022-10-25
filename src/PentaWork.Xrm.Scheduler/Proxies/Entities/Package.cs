using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{PackageUniqueName}")] 	
	[EntityLogicalName("package")]
	public sealed class Package : Entity
	{	
		public static readonly int? EntityTypeCode = 10007;
		public new const string LogicalName = "package";
		public const string PrimaryIdAttribute = "packageid";
		public const string PrimaryNameAttribute = "packageuniquename";
	
		public Package() : base("package") { }

		#region Attributes
		/// <summary>
        /// appid
        /// </summary>
		[DisplayName("AppId")]
		[AttributeLogicalName("appid")]
		public Guid AppId
		{	
			get { return GetAttributeValue<Guid>("appid"); }
			set
			{ 
				if(value == AppId) return;
				SetAttributeValue("appid", value);
			}
		}	
			
		/// <summary>
        /// applicationname
        /// </summary>
		[DisplayName("ApplicationName")]
		[AttributeLogicalName("applicationname")]
		public string ApplicationName
		{	
			get { return GetAttributeValue<string>("applicationname"); }
			set
			{ 
				if(value == ApplicationName) return;
				SetAttributeValue("applicationname", value);
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
        /// installedon
        /// </summary>
		[DisplayName("Installed On")]
		[AttributeLogicalName("installedon")]
		public DateTime? InstalledOn
		{	
			get { return GetAttributeValue<DateTime?>("installedon"); }
			set
			{ 
				if(value == InstalledOn) return;
				SetAttributeValue("installedon", value);
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
        /// packageid
        /// </summary>
		[DisplayName("PackageId")]
		[AttributeLogicalName("packageid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("packageid", value); }
		}

							/// <summary>
        /// packageinstanceid
        /// </summary>
		[DisplayName("PackageInstanceId")]
		[AttributeLogicalName("packageinstanceid")]
		public Guid PackageInstanceId
		{	
			get { return GetAttributeValue<Guid>("packageinstanceid"); }
			set
			{ 
				if(value == PackageInstanceId) return;
				SetAttributeValue("packageinstanceid", value);
			}
		}	
			
		/// <summary>
        /// packageinstanceoperationid
        /// </summary>
		[DisplayName("PackageInstanceOperationId")]
		[AttributeLogicalName("packageinstanceoperationid")]
		public Guid PackageInstanceOperationId
		{	
			get { return GetAttributeValue<Guid>("packageinstanceoperationid"); }
			set
			{ 
				if(value == PackageInstanceOperationId) return;
				SetAttributeValue("packageinstanceoperationid", value);
			}
		}	
			
		/// <summary>
        /// packageuniquename
        /// </summary>
		[DisplayName("Package Unique Name")]
		[AttributeLogicalName("packageuniquename")]
		public string PackageUniqueName
		{	
			get { return GetAttributeValue<string>("packageuniquename"); }
			set
			{ 
				if(value == PackageUniqueName) return;
				SetAttributeValue("packageuniquename", value);
			}
		}	
			
		/// <summary>
        /// packageversion
        /// </summary>
		[DisplayName("PackageVersion")]
		[AttributeLogicalName("packageversion")]
		public string PackageVersion
		{	
			get { return GetAttributeValue<string>("packageversion"); }
			set
			{ 
				if(value == PackageVersion) return;
				SetAttributeValue("packageversion", value);
			}
		}	
			
		/// <summary>
        /// publisherid
        /// </summary>
		[DisplayName("PublisherId")]
		[AttributeLogicalName("publisherid")]
		public Guid PublisherId
		{	
			get { return GetAttributeValue<Guid>("publisherid"); }
			set
			{ 
				if(value == PublisherId) return;
				SetAttributeValue("publisherid", value);
			}
		}	
			
		/// <summary>
        /// publishername
        /// </summary>
		[DisplayName("PublisherName")]
		[AttributeLogicalName("publishername")]
		public string PublisherName
		{	
			get { return GetAttributeValue<string>("publishername"); }
			set
			{ 
				if(value == PublisherName) return;
				SetAttributeValue("publishername", value);
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
        /// tpspackageid
        /// </summary>
		[DisplayName("TPSPackageId")]
		[AttributeLogicalName("tpspackageid")]
		public Guid TPSPackageId
		{	
			get { return GetAttributeValue<Guid>("tpspackageid"); }
			set
			{ 
				if(value == TPSPackageId) return;
				SetAttributeValue("tpspackageid", value);
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
        /// 1:N Get entities for 'package_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("package_AsyncOperations")]
		public IEnumerable<SystemJob> PackageAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("package_AsyncOperations", null); }
			set { SetRelatedEntities("package_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("package_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> PackageBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("package_BulkDeleteFailures", null); }
			set { SetRelatedEntities("package_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("package_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> PackageDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("package_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("package_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("package_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> PackageDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("package_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("package_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("package_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> PackageMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("package_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("package_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("package_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> PackagePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("package_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("package_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("package_ProcessSession")]
		public IEnumerable<ProcessSession> PackageProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("package_ProcessSession", null); }
			set { SetRelatedEntities("package_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'package_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("package_SyncErrors")]
		public IEnumerable<SyncError> PackageSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("package_SyncErrors", null); }
			set { SetRelatedEntities("package_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Solution'
        /// </summary>
		[RelationshipSchemaName("package_solution")]
		public IEnumerable<Solution> PackageSolution
		{
			get { return GetRelatedEntities<Solution>("package_solution", null); }
			set { SetRelatedEntities("package_solution", null, value); }
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
			/// <summary>appid</summary>
			public const string AppId = "appid";

			/// <summary>applicationname</summary>
			public const string ApplicationName = "applicationname";

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

			/// <summary>installedon</summary>
			public const string InstalledOn = "installedon";

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

			/// <summary>packageid</summary>
			public const string PackageId = "packageid";

			/// <summary>packageinstanceid</summary>
			public const string PackageInstanceId = "packageinstanceid";

			/// <summary>packageinstanceoperationid</summary>
			public const string PackageInstanceOperationId = "packageinstanceoperationid";

			/// <summary>packageuniquename</summary>
			public const string PackageUniqueName = "packageuniquename";

			/// <summary>packageversion</summary>
			public const string PackageVersion = "packageversion";

			/// <summary>publisherid</summary>
			public const string PublisherId = "publisherid";

			/// <summary>publishername</summary>
			public const string PublisherName = "publishername";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>tpspackageid</summary>
			public const string TPSPackageId = "tpspackageid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N package_AsyncOperations</summary>
			public const string PackageAsyncOperations = "package_AsyncOperations";

			/// <summary>1:N package_BulkDeleteFailures</summary>
			public const string PackageBulkDeleteFailures = "package_BulkDeleteFailures";

			/// <summary>1:N package_DuplicateBaseRecord</summary>
			public const string PackageDuplicateBaseRecord = "package_DuplicateBaseRecord";

			/// <summary>1:N package_DuplicateMatchingRecord</summary>
			public const string PackageDuplicateMatchingRecord = "package_DuplicateMatchingRecord";

			/// <summary>1:N package_MailboxTrackingFolders</summary>
			public const string PackageMailboxTrackingFolders = "package_MailboxTrackingFolders";

			/// <summary>1:N package_PrincipalObjectAttributeAccesses</summary>
			public const string PackagePrincipalObjectAttributeAccesses = "package_PrincipalObjectAttributeAccesses";

			/// <summary>1:N package_ProcessSession</summary>
			public const string PackageProcessSession = "package_ProcessSession";

			/// <summary>1:N package_SyncErrors</summary>
			public const string PackageSyncErrors = "package_SyncErrors";

			/// <summary>N:N package_solution</summary>
			public const string PackageSolution = "package_solution";

		}
		#endregion
	}
}

