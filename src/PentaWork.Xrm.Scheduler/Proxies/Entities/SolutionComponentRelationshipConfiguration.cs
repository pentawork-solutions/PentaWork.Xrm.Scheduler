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
	[EntityLogicalName("solutioncomponentrelationshipconfiguration")]
	public sealed class SolutionComponentRelationshipConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 10004;
		public new const string LogicalName = "solutioncomponentrelationshipconfiguration";
		public const string PrimaryIdAttribute = "solutioncomponentrelationshipconfigurationid";
		public const string PrimaryNameAttribute = "name";
	
		public SolutionComponentRelationshipConfiguration() : base("solutioncomponentrelationshipconfiguration") { }

		#region Attributes
		/// <summary>
        /// componentidunique
        /// </summary>
		[DisplayName("Row id unique")]
		[AttributeLogicalName("componentidunique")]
		public Guid RowIdUniqueId
		{	
			get { return GetAttributeValue<Guid>("componentidunique"); }
			set
			{ 
				if(value == RowIdUniqueId) return;
				SetAttributeValue("componentidunique", value);
			}
		}	
			
		/// <summary>
        /// componentstate
        /// </summary>
		[DisplayName("Component State")]
		[AttributeLogicalName("componentstate")]
		public egComponentState? ComponentState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componentstate");
				if (optionSetValue != null) return (egComponentState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
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
        /// entityrelationshipid
        /// </summary>
		[DisplayName("Entity Relationship")]
		[AttributeLogicalName("entityrelationshipid")]
		public EntityReference EntityRelationship
		{	
			get { return GetAttributeValue<EntityReference>("entityrelationshipid"); }
			set
			{ 
				if(value == EntityRelationship) return;
				SetAttributeValue("entityrelationshipid", value);
			}
		}	
			
		/// <summary>
        /// entityrelationshipidname
        /// </summary>
		[DisplayName("entityrelationshipidname")]
		[AttributeLogicalName("entityrelationshipidname")]
		public string Entityrelationshipidname
		{	
			get { return GetAttributeValue<string>("entityrelationshipidname"); }
			set
			{ 
				if(value == Entityrelationshipidname) return;
				SetAttributeValue("entityrelationshipidname", value);
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
        /// ismanaged
        /// </summary>
		[DisplayName("Is Managed")]
		[AttributeLogicalName("ismanaged")]
		public bool? IsManaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == IsManaged) return;
				SetAttributeValue("ismanaged", value);
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
        /// overwritetime
        /// </summary>
		[DisplayName("Record Overwrite Time")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? RecordOverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == RecordOverwriteTime) return;
				SetAttributeValue("overwritetime", value);
			}
		}	
			
		/// <summary>
        /// primaryentitydependencytype
        /// </summary>
		[DisplayName("PrimaryEntityDependencyType")]
		[AttributeLogicalName("primaryentitydependencytype")]
		public ePrimaryEntityDependencyType? PrimaryEntityDependencyType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("primaryentitydependencytype");
				if (optionSetValue != null) return (ePrimaryEntityDependencyType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PrimaryEntityDependencyType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("primaryentitydependencytype", optionSetValue); 
			}
		}

		/// <summary>
        /// secondaryentitydependencytype
        /// </summary>
		[DisplayName("SecondaryEntityDependencyType")]
		[AttributeLogicalName("secondaryentitydependencytype")]
		public eSecondaryEntityDependencyType? SecondaryEntityDependencyType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("secondaryentitydependencytype");
				if (optionSetValue != null) return (eSecondaryEntityDependencyType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SecondaryEntityDependencyType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("secondaryentitydependencytype", optionSetValue); 
			}
		}

		/// <summary>
        /// solutioncomponentrelationshipconfigurationid
        /// </summary>
		[DisplayName("Solution Component Relationship Configuration")]
		[AttributeLogicalName("solutioncomponentrelationshipconfigurationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("solutioncomponentrelationshipconfigurationid", value); }
		}

							/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("solutionid", value);
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
        /// supportingsolutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("supportingsolutionid")]
		public Guid SolutionId2
		{	
			get { return GetAttributeValue<Guid>("supportingsolutionid"); }
			set
			{ 
				if(value == SolutionId2) return;
				SetAttributeValue("supportingsolutionid", value);
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
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_AsyncOperations")]
		public IEnumerable<SystemJob> SolutioncomponentrelationshipconfigurationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("solutioncomponentrelationshipconfiguration_AsyncOperations", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SolutioncomponentrelationshipconfigurationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("solutioncomponentrelationshipconfiguration_BulkDeleteFailures", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SolutioncomponentrelationshipconfigurationDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("solutioncomponentrelationshipconfiguration_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SolutioncomponentrelationshipconfigurationDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SolutioncomponentrelationshipconfigurationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("solutioncomponentrelationshipconfiguration_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> SolutioncomponentrelationshipconfigurationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_ProcessSession")]
		public IEnumerable<ProcessSession> SolutioncomponentrelationshipconfigurationProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("solutioncomponentrelationshipconfiguration_ProcessSession", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentrelationshipconfiguration_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentrelationshipconfiguration_SyncErrors")]
		public IEnumerable<SyncError> SolutioncomponentrelationshipconfigurationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("solutioncomponentrelationshipconfiguration_SyncErrors", null); }
			set { SetRelatedEntities("solutioncomponentrelationshipconfiguration_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egComponentState
		{	
		
			[Label("Published")]
			[Description(@"")]
			Published = 0, 
		
			[Label("Unpublished")]
			[Description(@"")]
			Unpublished = 1, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted = 2, 
		
			[Label("Deleted Unpublished")]
			[Description(@"")]
			DeletedUnpublished = 3, 
		}
		
		public enum ePrimaryEntityDependencyType
		{	
		
			[Label("Hard Dependency")]
			[Description(@"")]
			HardDependency = 0, 
		
			[Label("Soft Dependency")]
			[Description(@"")]
			SoftDependency = 1, 
		}
		
		public enum eSecondaryEntityDependencyType
		{	
		
			[Label("Hard Dependency")]
			[Description(@"")]
			HardDependency = 0, 
		
			[Label("Soft Dependency")]
			[Description(@"")]
			SoftDependency = 1, 
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
			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>entityrelationshipid</summary>
			public const string EntityRelationship = "entityrelationshipid";

			/// <summary>entityrelationshipidname</summary>
			public const string Entityrelationshipidname = "entityrelationshipidname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

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

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>primaryentitydependencytype</summary>
			public const string PrimaryEntityDependencyType = "primaryentitydependencytype";

			/// <summary>secondaryentitydependencytype</summary>
			public const string SecondaryEntityDependencyType = "secondaryentitydependencytype";

			/// <summary>solutioncomponentrelationshipconfigurationid</summary>
			public const string SolutionComponentRelationshipConfigurationId = "solutioncomponentrelationshipconfigurationid";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

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
			/// <summary>1:N solutioncomponentrelationshipconfiguration_AsyncOperations</summary>
			public const string SolutioncomponentrelationshipconfigurationAsyncOperations = "solutioncomponentrelationshipconfiguration_AsyncOperations";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_BulkDeleteFailures</summary>
			public const string SolutioncomponentrelationshipconfigurationBulkDeleteFailures = "solutioncomponentrelationshipconfiguration_BulkDeleteFailures";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_DuplicateBaseRecord</summary>
			public const string SolutioncomponentrelationshipconfigurationDuplicateBaseRecord = "solutioncomponentrelationshipconfiguration_DuplicateBaseRecord";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord</summary>
			public const string SolutioncomponentrelationshipconfigurationDuplicateMatchingRecord = "solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_MailboxTrackingFolders</summary>
			public const string SolutioncomponentrelationshipconfigurationMailboxTrackingFolders = "solutioncomponentrelationshipconfiguration_MailboxTrackingFolders";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses</summary>
			public const string SolutioncomponentrelationshipconfigurationPrincipalObjectAttributeAccesses = "solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_ProcessSession</summary>
			public const string SolutioncomponentrelationshipconfigurationProcessSession = "solutioncomponentrelationshipconfiguration_ProcessSession";

			/// <summary>1:N solutioncomponentrelationshipconfiguration_SyncErrors</summary>
			public const string SolutioncomponentrelationshipconfigurationSyncErrors = "solutioncomponentrelationshipconfiguration_SyncErrors";

		}
		#endregion
	}
}

