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
	[EntityLogicalName("solutioncomponentattributeconfiguration")]
	public sealed class SolutionComponentAttributeConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 10002;
		public new const string LogicalName = "solutioncomponentattributeconfiguration";
		public const string PrimaryIdAttribute = "solutioncomponentattributeconfigurationid";
		public const string PrimaryNameAttribute = "name";
	
		public SolutionComponentAttributeConfiguration() : base("solutioncomponentattributeconfiguration") { }

		#region Attributes
		/// <summary>
        /// attributeid
        /// </summary>
		[DisplayName("Attribute")]
		[AttributeLogicalName("attributeid")]
		public EntityReference Attribute
		{	
			get { return GetAttributeValue<EntityReference>("attributeid"); }
			set
			{ 
				if(value == Attribute) return;
				SetAttributeValue("attributeid", value);
			}
		}	
			
		/// <summary>
        /// attributeidname
        /// </summary>
		[DisplayName("attributeidname")]
		[AttributeLogicalName("attributeidname")]
		public string Attributeidname
		{	
			get { return GetAttributeValue<string>("attributeidname"); }
			set
			{ 
				if(value == Attributeidname) return;
				SetAttributeValue("attributeidname", value);
			}
		}	
			
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
        /// encodingformat
        /// </summary>
		[DisplayName("Encoding Format")]
		[AttributeLogicalName("encodingformat")]
		public eEncodingFormat? EncodingFormat
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("encodingformat");
				if (optionSetValue != null) return (eEncodingFormat)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EncodingFormat) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("encodingformat", optionSetValue); 
			}
		}

		/// <summary>
        /// fileextension
        /// </summary>
		[DisplayName("File Extension")]
		[AttributeLogicalName("fileextension")]
		public string FileExtension
		{	
			get { return GetAttributeValue<string>("fileextension"); }
			set
			{ 
				if(value == FileExtension) return;
				SetAttributeValue("fileextension", value);
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
        /// isexportdisabled
        /// </summary>
		[DisplayName("Export Disabled")]
		[AttributeLogicalName("isexportdisabled")]
		public bool? ExportDisabled
		{	
			get { return GetAttributeValue<bool?>("isexportdisabled"); }
			set
			{ 
				if(value == ExportDisabled) return;
				SetAttributeValue("isexportdisabled", value);
			}
		}	
			
		/// <summary>
        /// isexportedasfile
        /// </summary>
		[DisplayName("IsExportedAsFile")]
		[AttributeLogicalName("isexportedasfile")]
		public bool? IsExportedAsFile
		{	
			get { return GetAttributeValue<bool?>("isexportedasfile"); }
			set
			{ 
				if(value == IsExportedAsFile) return;
				SetAttributeValue("isexportedasfile", value);
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
        /// solutioncomponentattributeconfigurationid
        /// </summary>
		[DisplayName("Solution Component Attribute Configuration")]
		[AttributeLogicalName("solutioncomponentattributeconfigurationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("solutioncomponentattributeconfigurationid", value); }
		}

							/// <summary>
        /// solutioncomponentconfigurationid
        /// </summary>
		[DisplayName("Solution Component Attribute Configuration")]
		[AttributeLogicalName("solutioncomponentconfigurationid")]
		public EntityReference SolutionComponentAttributeConfiguration2
		{	
			get { return GetAttributeValue<EntityReference>("solutioncomponentconfigurationid"); }
			set
			{ 
				if(value == SolutionComponentAttributeConfiguration2) return;
				SetAttributeValue("solutioncomponentconfigurationid", value);
			}
		}	
			
		/// <summary>
        /// solutioncomponentconfigurationidname
        /// </summary>
		[DisplayName("solutioncomponentconfigurationidname")]
		[AttributeLogicalName("solutioncomponentconfigurationidname")]
		public string Solutioncomponentconfigurationidname
		{	
			get { return GetAttributeValue<string>("solutioncomponentconfigurationidname"); }
			set
			{ 
				if(value == Solutioncomponentconfigurationidname) return;
				SetAttributeValue("solutioncomponentconfigurationidname", value);
			}
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
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_AsyncOperations")]
		public IEnumerable<SystemJob> SolutioncomponentattributeconfigurationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("solutioncomponentattributeconfiguration_AsyncOperations", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SolutioncomponentattributeconfigurationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("solutioncomponentattributeconfiguration_BulkDeleteFailures", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SolutioncomponentattributeconfigurationDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("solutioncomponentattributeconfiguration_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SolutioncomponentattributeconfigurationDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("solutioncomponentattributeconfiguration_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SolutioncomponentattributeconfigurationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("solutioncomponentattributeconfiguration_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> SolutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_ProcessSession")]
		public IEnumerable<ProcessSession> SolutioncomponentattributeconfigurationProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("solutioncomponentattributeconfiguration_ProcessSession", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solutioncomponentattributeconfiguration_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("solutioncomponentattributeconfiguration_SyncErrors")]
		public IEnumerable<SyncError> SolutioncomponentattributeconfigurationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("solutioncomponentattributeconfiguration_SyncErrors", null); }
			set { SetRelatedEntities("solutioncomponentattributeconfiguration_SyncErrors", null, value); }
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
		
		public enum eEncodingFormat
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Base64")]
			[Description(@"")]
			Base64 = 1, 
		
			[Label("UTF8")]
			[Description(@"")]
			UTF8 = 2, 
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
			/// <summary>attributeid</summary>
			public const string Attribute = "attributeid";

			/// <summary>attributeidname</summary>
			public const string Attributeidname = "attributeidname";

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

			/// <summary>encodingformat</summary>
			public const string EncodingFormat = "encodingformat";

			/// <summary>fileextension</summary>
			public const string FileExtension = "fileextension";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isexportdisabled</summary>
			public const string ExportDisabled = "isexportdisabled";

			/// <summary>isexportedasfile</summary>
			public const string IsExportedAsFile = "isexportedasfile";

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

			/// <summary>solutioncomponentattributeconfigurationid</summary>
			public const string SolutionComponentAttributeConfigurationId = "solutioncomponentattributeconfigurationid";

			/// <summary>solutioncomponentconfigurationid</summary>
			public const string SolutionComponentAttributeConfiguration2 = "solutioncomponentconfigurationid";

			/// <summary>solutioncomponentconfigurationidname</summary>
			public const string Solutioncomponentconfigurationidname = "solutioncomponentconfigurationidname";

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
			/// <summary>1:N solutioncomponentattributeconfiguration_AsyncOperations</summary>
			public const string SolutioncomponentattributeconfigurationAsyncOperations = "solutioncomponentattributeconfiguration_AsyncOperations";

			/// <summary>1:N solutioncomponentattributeconfiguration_BulkDeleteFailures</summary>
			public const string SolutioncomponentattributeconfigurationBulkDeleteFailures = "solutioncomponentattributeconfiguration_BulkDeleteFailures";

			/// <summary>1:N solutioncomponentattributeconfiguration_DuplicateBaseRecord</summary>
			public const string SolutioncomponentattributeconfigurationDuplicateBaseRecord = "solutioncomponentattributeconfiguration_DuplicateBaseRecord";

			/// <summary>1:N solutioncomponentattributeconfiguration_DuplicateMatchingRecord</summary>
			public const string SolutioncomponentattributeconfigurationDuplicateMatchingRecord = "solutioncomponentattributeconfiguration_DuplicateMatchingRecord";

			/// <summary>1:N solutioncomponentattributeconfiguration_MailboxTrackingFolders</summary>
			public const string SolutioncomponentattributeconfigurationMailboxTrackingFolders = "solutioncomponentattributeconfiguration_MailboxTrackingFolders";

			/// <summary>1:N solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses</summary>
			public const string SolutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses = "solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses";

			/// <summary>1:N solutioncomponentattributeconfiguration_ProcessSession</summary>
			public const string SolutioncomponentattributeconfigurationProcessSession = "solutioncomponentattributeconfiguration_ProcessSession";

			/// <summary>1:N solutioncomponentattributeconfiguration_SyncErrors</summary>
			public const string SolutioncomponentattributeconfigurationSyncErrors = "solutioncomponentattributeconfiguration_SyncErrors";

		}
		#endregion
	}
}

