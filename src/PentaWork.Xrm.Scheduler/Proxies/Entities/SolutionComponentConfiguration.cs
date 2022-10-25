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
	[EntityLogicalName("solutioncomponentconfiguration")]
	public sealed class SolutionComponentConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 10003;
		public new const string LogicalName = "solutioncomponentconfiguration";
		public const string PrimaryIdAttribute = "solutioncomponentconfigurationid";
		public const string PrimaryNameAttribute = "name";
	
		public SolutionComponentConfiguration() : base("solutioncomponentconfiguration") { }

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
        /// entityid
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("entityid")]
		public EntityReference Entity
		{	
			get { return GetAttributeValue<EntityReference>("entityid"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("entityid", value);
			}
		}	
			
		/// <summary>
        /// entityidname
        /// </summary>
		[DisplayName("entityidname")]
		[AttributeLogicalName("entityidname")]
		public string Entityidname
		{	
			get { return GetAttributeValue<string>("entityidname"); }
			set
			{ 
				if(value == Entityidname) return;
				SetAttributeValue("entityidname", value);
			}
		}	
			
		/// <summary>
        /// fileformat
        /// </summary>
		[DisplayName("File Format")]
		[AttributeLogicalName("fileformat")]
		public eFileFormat? FileFormat
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fileformat");
				if (optionSetValue != null) return (eFileFormat)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FileFormat) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fileformat", optionSetValue); 
			}
		}

		/// <summary>
        /// filescope
        /// </summary>
		[DisplayName("File Scope")]
		[AttributeLogicalName("filescope")]
		public eFileScope? FileScope
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("filescope");
				if (optionSetValue != null) return (eFileScope)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FileScope) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("filescope", optionSetValue); 
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
        /// isdisplayable
        /// </summary>
		[DisplayName("Displayable")]
		[AttributeLogicalName("isdisplayable")]
		public bool? Displayable
		{	
			get { return GetAttributeValue<bool?>("isdisplayable"); }
			set
			{ 
				if(value == Displayable) return;
				SetAttributeValue("isdisplayable", value);
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
        /// issoftdeleteenabled
        /// </summary>
		[DisplayName("IsSoftDeleteEnabled")]
		[AttributeLogicalName("issoftdeleteenabled")]
		public bool? IsSoftDeleteEnabled
		{	
			get { return GetAttributeValue<bool?>("issoftdeleteenabled"); }
			set
			{ 
				if(value == IsSoftDeleteEnabled) return;
				SetAttributeValue("issoftdeleteenabled", value);
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
        /// solutioncomponentconfigurationid
        /// </summary>
		[DisplayName("Solution Component Configuration")]
		[AttributeLogicalName("solutioncomponentconfigurationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("solutioncomponentconfigurationid", value); }
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
        /// 1:N Get entities for 'solutioncomponentconfig_solutioncomponentattrconfig'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfig_solutioncomponentattrconfig")]
		public IEnumerable<SolutionComponentAttributeConfiguration> SolutioncomponentconfigSolutioncomponentattrconfig
		{
			get { return GetRelatedEntities<SolutionComponentAttributeConfiguration>("solutioncomponentconfig_solutioncomponentattrconfig", null); }
			set { SetRelatedEntities("solutioncomponentconfig_solutioncomponentattrconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_AsyncOperations")]
		public IEnumerable<SystemJob> SolutioncomponentconfigurationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("solutioncomponentconfiguration_AsyncOperations", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SolutioncomponentconfigurationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("solutioncomponentconfiguration_BulkDeleteFailures", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SolutioncomponentconfigurationDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("solutioncomponentconfiguration_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SolutioncomponentconfigurationDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("solutioncomponentconfiguration_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SolutioncomponentconfigurationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("solutioncomponentconfiguration_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> SolutioncomponentconfigurationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_ProcessSession")]
		public IEnumerable<ProcessSession> SolutioncomponentconfigurationProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("solutioncomponentconfiguration_ProcessSession", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentconfiguration_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentconfiguration_SyncErrors")]
		public IEnumerable<SyncError> SolutioncomponentconfigurationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("solutioncomponentconfiguration_SyncErrors", null); }
			set { SetRelatedEntities("solutioncomponentconfiguration_SyncErrors", null, value); }
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
		
		public enum eFileFormat
		{	
		
			[Label("xml")]
			[Description(@"")]
			Xml = 0, 
		
			[Label("json")]
			[Description(@"")]
			Json = 1, 
		}
		
		public enum eFileScope
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Individual")]
			[Description(@"")]
			Individual = 1, 
		
			[Label("Global")]
			[Description(@"")]
			Global = 2, 
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

			/// <summary>entityid</summary>
			public const string Entity = "entityid";

			/// <summary>entityidname</summary>
			public const string Entityidname = "entityidname";

			/// <summary>fileformat</summary>
			public const string FileFormat = "fileformat";

			/// <summary>filescope</summary>
			public const string FileScope = "filescope";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdisplayable</summary>
			public const string Displayable = "isdisplayable";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>issoftdeleteenabled</summary>
			public const string IsSoftDeleteEnabled = "issoftdeleteenabled";

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

			/// <summary>solutioncomponentconfigurationid</summary>
			public const string SolutionComponentConfigurationId = "solutioncomponentconfigurationid";

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
			/// <summary>1:N solutioncomponentconfig_solutioncomponentattrconfig</summary>
			public const string SolutioncomponentconfigSolutioncomponentattrconfig = "solutioncomponentconfig_solutioncomponentattrconfig";

			/// <summary>1:N solutioncomponentconfiguration_AsyncOperations</summary>
			public const string SolutioncomponentconfigurationAsyncOperations = "solutioncomponentconfiguration_AsyncOperations";

			/// <summary>1:N solutioncomponentconfiguration_BulkDeleteFailures</summary>
			public const string SolutioncomponentconfigurationBulkDeleteFailures = "solutioncomponentconfiguration_BulkDeleteFailures";

			/// <summary>1:N solutioncomponentconfiguration_DuplicateBaseRecord</summary>
			public const string SolutioncomponentconfigurationDuplicateBaseRecord = "solutioncomponentconfiguration_DuplicateBaseRecord";

			/// <summary>1:N solutioncomponentconfiguration_DuplicateMatchingRecord</summary>
			public const string SolutioncomponentconfigurationDuplicateMatchingRecord = "solutioncomponentconfiguration_DuplicateMatchingRecord";

			/// <summary>1:N solutioncomponentconfiguration_MailboxTrackingFolders</summary>
			public const string SolutioncomponentconfigurationMailboxTrackingFolders = "solutioncomponentconfiguration_MailboxTrackingFolders";

			/// <summary>1:N solutioncomponentconfiguration_PrincipalObjectAttributeAccesses</summary>
			public const string SolutioncomponentconfigurationPrincipalObjectAttributeAccesses = "solutioncomponentconfiguration_PrincipalObjectAttributeAccesses";

			/// <summary>1:N solutioncomponentconfiguration_ProcessSession</summary>
			public const string SolutioncomponentconfigurationProcessSession = "solutioncomponentconfiguration_ProcessSession";

			/// <summary>1:N solutioncomponentconfiguration_SyncErrors</summary>
			public const string SolutioncomponentconfigurationSyncErrors = "solutioncomponentconfiguration_SyncErrors";

		}
		#endregion
	}
}

