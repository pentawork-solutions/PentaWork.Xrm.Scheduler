using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{MapName}")] 	
	[EntityLogicalName("importmap")]
	public sealed class DataMap : Entity
	{	
		public static readonly int? EntityTypeCode = 4411;
		public new const string LogicalName = "importmap";
		public const string PrimaryIdAttribute = "importmapid";
		public const string PrimaryNameAttribute = "name";
	
		public DataMap() : base("importmap") { }

		#region Attributes
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
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// entitiesperfile
        /// </summary>
		[DisplayName("Entities Per File")]
		[AttributeLogicalName("entitiesperfile")]
		public eEntitiesPerFile? EntitiesPerFile
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("entitiesperfile");
				if (optionSetValue != null) return (eEntitiesPerFile)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EntitiesPerFile) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("entitiesperfile", optionSetValue); 
			}
		}

		/// <summary>
        /// importmapid
        /// </summary>
		[DisplayName("Data Map")]
		[AttributeLogicalName("importmapid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("importmapid", value); }
		}

							/// <summary>
        /// importmapidunique
        /// </summary>
		[DisplayName("importmapidunique")]
		[AttributeLogicalName("importmapidunique")]
		public Guid ImportmapiduniqueId
		{	
			get { return GetAttributeValue<Guid>("importmapidunique"); }
			set
			{ 
				if(value == ImportmapiduniqueId) return;
				SetAttributeValue("importmapidunique", value);
			}
		}	
			
		/// <summary>
        /// importmaptype
        /// </summary>
		[DisplayName("Map Type")]
		[AttributeLogicalName("importmaptype")]
		public eMapType? MapType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("importmaptype");
				if (optionSetValue != null) return (eMapType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MapType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("importmaptype", optionSetValue); 
			}
		}

		/// <summary>
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("State")]
		[AttributeLogicalName("ismanaged")]
		public bool? State
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == State) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// isvalidforimport
        /// </summary>
		[DisplayName("Is Valid For Import")]
		[AttributeLogicalName("isvalidforimport")]
		public bool? IsValidForImport
		{	
			get { return GetAttributeValue<bool?>("isvalidforimport"); }
			set
			{ 
				if(value == IsValidForImport) return;
				SetAttributeValue("isvalidforimport", value);
			}
		}	
			
		/// <summary>
        /// iswizardcreated
        /// </summary>
		[DisplayName("Is Wizard-Created")]
		[AttributeLogicalName("iswizardcreated")]
		public bool? IsWizardCreated
		{	
			get { return GetAttributeValue<bool?>("iswizardcreated"); }
			set
			{ 
				if(value == IsWizardCreated) return;
				SetAttributeValue("iswizardcreated", value);
			}
		}	
			
		/// <summary>
        /// mapcustomizations
        /// </summary>
		[DisplayName("Map Customizations")]
		[AttributeLogicalName("mapcustomizations")]
		public string MapCustomizations
		{	
			get { return GetAttributeValue<string>("mapcustomizations"); }
			set
			{ 
				if(value == MapCustomizations) return;
				SetAttributeValue("mapcustomizations", value);
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
		[DisplayName("Map Name")]
		[AttributeLogicalName("name")]
		public string MapName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == MapName) return;
				SetAttributeValue("name", value);
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
        /// source
        /// </summary>
		[DisplayName("Source")]
		[AttributeLogicalName("source")]
		public string Source
		{	
			get { return GetAttributeValue<string>("source"); }
			set
			{ 
				if(value == Source) return;
				SetAttributeValue("source", value);
			}
		}	
			
		/// <summary>
        /// sourcetype
        /// </summary>
		[DisplayName("Source System Type")]
		[AttributeLogicalName("sourcetype")]
		public eSourceSystemType? SourceSystemType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("sourcetype");
				if (optionSetValue != null) return (eSourceSystemType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SourceSystemType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("sourcetype", optionSetValue); 
			}
		}

		/// <summary>
        /// sourceuseridentifierforsourcecrmuserlink
        /// </summary>
		[DisplayName("Source User Value")]
		[AttributeLogicalName("sourceuseridentifierforsourcecrmuserlink")]
		public string SourceUserValue
		{	
			get { return GetAttributeValue<string>("sourceuseridentifierforsourcecrmuserlink"); }
			set
			{ 
				if(value == SourceUserValue) return;
				SetAttributeValue("sourceuseridentifierforsourcecrmuserlink", value);
			}
		}	
			
		/// <summary>
        /// sourceuseridentifierforsourcedatasourceuserlink
        /// </summary>
		[DisplayName("Source User Identifier")]
		[AttributeLogicalName("sourceuseridentifierforsourcedatasourceuserlink")]
		public string SourceUserIdentifier
		{	
			get { return GetAttributeValue<string>("sourceuseridentifierforsourcedatasourceuserlink"); }
			set
			{ 
				if(value == SourceUserIdentifier) return;
				SetAttributeValue("sourceuseridentifierforsourcedatasourceuserlink", value);
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
        /// targetentity
        /// </summary>
		[DisplayName("Record Type")]
		[AttributeLogicalName("targetentity")]
		public eRecordType? RecordType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("targetentity");
				if (optionSetValue != null) return (eRecordType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RecordType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("targetentity", optionSetValue); 
			}
		}

		/// <summary>
        /// targetuseridentifierforsourcecrmuserlink
        /// </summary>
		[DisplayName("Target User Value")]
		[AttributeLogicalName("targetuseridentifierforsourcecrmuserlink")]
		public string TargetUserValue
		{	
			get { return GetAttributeValue<string>("targetuseridentifierforsourcecrmuserlink"); }
			set
			{ 
				if(value == TargetUserValue) return;
				SetAttributeValue("targetuseridentifierforsourcecrmuserlink", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ColumnMapping_ImportMap'
        /// </summary>
		[RelationshipSchemaName("ColumnMapping_ImportMap")]
		public IEnumerable<ColumnMapping> ColumnMappingImportMap
		{
			get { return GetRelatedEntities<ColumnMapping>("ColumnMapping_ImportMap", null); }
			set { SetRelatedEntities("ColumnMapping_ImportMap", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportEntityMapping_ImportMap'
        /// </summary>
		[RelationshipSchemaName("ImportEntityMapping_ImportMap")]
		public IEnumerable<ImportEntityMapping> ImportEntityMappingImportMap
		{
			get { return GetRelatedEntities<ImportEntityMapping>("ImportEntityMapping_ImportMap", null); }
			set { SetRelatedEntities("ImportEntityMapping_ImportMap", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportMap_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ImportMap_AsyncOperations")]
		public IEnumerable<SystemJob> ImportMapAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ImportMap_AsyncOperations", null); }
			set { SetRelatedEntities("ImportMap_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportMap_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ImportMap_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ImportMapBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ImportMap_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ImportMap_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportMap_ImportFile'
        /// </summary>
		[RelationshipSchemaName("ImportMap_ImportFile")]
		public IEnumerable<ImportSourceFile> ImportMapImportFile
		{
			get { return GetRelatedEntities<ImportSourceFile>("ImportMap_ImportFile", null); }
			set { SetRelatedEntities("ImportMap_ImportFile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportMap_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ImportMap_SyncErrors")]
		public IEnumerable<SyncError> ImportMapSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ImportMap_SyncErrors", null); }
			set { SetRelatedEntities("ImportMap_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OwnerMapping_ImportMap'
        /// </summary>
		[RelationshipSchemaName("OwnerMapping_ImportMap")]
		public IEnumerable<OwnerMapping> OwnerMappingImportMap
		{
			get { return GetRelatedEntities<OwnerMapping>("OwnerMapping_ImportMap", null); }
			set { SetRelatedEntities("OwnerMapping_ImportMap", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransformationMapping_ImportMap'
        /// </summary>
		[RelationshipSchemaName("TransformationMapping_ImportMap")]
		public IEnumerable<TransformationMapping> TransformationMappingImportMap
		{
			get { return GetRelatedEntities<TransformationMapping>("TransformationMapping_ImportMap", null); }
			set { SetRelatedEntities("TransformationMapping_ImportMap", null, value); }
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
		
		public enum eEntitiesPerFile
		{	
		
			[Label("Single Entity Per File")]
			[Description(@"")]
			SingleEntityPerFile = 1, 
		
			[Label("Multiple Entities Per File")]
			[Description(@"")]
			MultipleEntitiesPerFile = 2, 
		}
		
		public enum eMapType
		{	
		
			[Label("Standard")]
			[Description(@"")]
			Standard = 1, 
		
			[Label("Out of Box")]
			[Description(@"")]
			OutOfBox = 2, 
		
			[Label("In Process")]
			[Description(@"")]
			InProcess = 3, 
		}
		
		public enum eSourceSystemType
		{	
		
			[Label("Map For SalesForce.com Full Data Export")]
			[Description(@"")]
			MapForSalesForcecomFullDataExport = 1, 
		
			[Label("Map For SalesForce.com Report Export")]
			[Description(@"")]
			MapForSalesForcecomReportExport = 2, 
		
			[Label("Map For SalesForce.com Contact and Account Report Export")]
			[Description(@"")]
			MapForSalesForcecomContactAndAccountReportExport = 3, 
		
			[Label("Microsoft Office Outlook 2010 with Business Contact Manager")]
			[Description(@"")]
			MicrosoftOfficeOutlook2010WithBusinessContactManager = 4, 
		
			[Label("Generic Map for Contact and Account")]
			[Description(@"")]
			GenericMapForContactAndAccount = 5, 
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
		
		public enum eRecordType
		{	
		
			[Label("Process Session")]
			[Description(@"Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.")]
			ProcessSession = 4710, 
		
			[Label("Privilege Object Type Code")]
			[Description(@"For internal use only.")]
			PrivilegeObjectTypeCode = 31, 
		
			[Label("ProcessStageParameter")]
			[Description(@"")]
			ProcessStageParameter = 10028, 
		
			[Label("Process Stage")]
			[Description(@"Stage associated with a process.")]
			ProcessStage = 4724, 
		
			[Label("Field Sharing")]
			[Description(@"Defines CRM security principals (users and teams) access rights to secured field for an entity instance.")]
			FieldSharing = 44, 
		
			[Label("Price List")]
			[Description(@"Entity that defines pricing levels.")]
			PriceList = 1022, 
		
			[Label("Privilege")]
			[Description(@"Permission to perform an action in Microsoft CRM. The platform checks for the privilege and rejects the attempt if the user does not hold the privilege.")]
			Privilege = 1023, 
		
			[Label("Principal Sync Attribute Map")]
			[Description(@"Maps security principals (users and teams) to sync attribute mappings.")]
			PrincipalSyncAttributeMap = 1404, 
		
			[Label("Product Relationship")]
			[Description(@"Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory.")]
			ProductRelationship = 1028, 
		
			[Label("ProductSalesLiterature")]
			[Description(@"")]
			ProductSalesLiterature = 21, 
		
			[Label("Publisher")]
			[Description(@"A publisher of a CRM solution.")]
			Publisher = 7101, 
		
			[Label("ProvisionLanguageForUser")]
			[Description(@"")]
			ProvisionLanguageForUser = 10017, 
		
			[Label("Product")]
			[Description(@"Information about products and their pricing information.")]
			Product = 1024, 
		
			[Label("Process Trigger")]
			[Description(@"Trigger that invoke a rule.")]
			ProcessTrigger = 4712, 
		
			[Label("Price List Item")]
			[Description(@"Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.")]
			PriceListItem = 1026, 
		
			[Label("Product Association")]
			[Description(@"Instance of a product added to a bundle or kit.")]
			ProductAssociation = 1025, 
		
			[Label("Plug-in Assembly")]
			[Description(@"Assembly that contains one or more plug-in types.")]
			PluginAssembly = 4605, 
		
			[Label("List Value Mapping")]
			[Description(@"In a data map, maps list values from the source file to Microsoft Dynamics 365.")]
			ListValueMapping = 4418, 
		
			[Label("Plug-in Type")]
			[Description(@"Type that inherits from the IPlugin interface and is contained within a plug-in assembly.")]
			PluginType = 4602, 
		
			[Label("Plug-in Trace Log")]
			[Description(@"Trace and exception information generated by plug-ins and custom workflow activities.")]
			PluginTraceLog = 4619, 
		
			[Label("Personal Document Template")]
			[Description(@"Used to store Personal Document Templates in database in binary format.")]
			PersonalDocumentTemplate = 9941, 
		
			[Label("PDF Setting")]
			[Description(@"PDF Settings to save enabled pdf entities")]
			PDFSetting = 10039, 
		
			[Label("Phone To Case Process")]
			[Description(@"Phone To Case Process Business Process Flow")]
			PhoneToCaseProcess = 952, 
		
			[Label("Phone Call")]
			[Description(@"Activity to track a telephone call.")]
			PhoneCall = 4210, 
		
			[Label("Like")]
			[Description(@"A like on an activity feed post.")]
			Like = 8006, 
		
			[Label("Follow")]
			[Description(@"Represents a user following the activity feed of an object.")]
			Follow = 8003, 
		
			[Label("Post Role")]
			[Description(@"Represents the objects with which an activity feed post is associated. For internal use only.")]
			PostRole = 8001, 
		
			[Label("Post Regarding")]
			[Description(@"Represents which object an activity feed post is regarding. For internal use only.")]
			PostRegarding = 8002, 
		
			[Label("Position")]
			[Description(@"Position of a user in the hierarchy")]
			Position = 50, 
		
			[Label("Plug-in Type Statistic")]
			[Description(@"Plug-in type statistic.")]
			PluginTypeStatistic = 4603, 
		
			[Label("Comment")]
			[Description(@"A comment on an activity feed post.")]
			Comment = 8005, 
		
			[Label("Post")]
			[Description(@"An activity feed post.")]
			Post = 8000, 
		
			[Label("Publisher Address")]
			[Description(@"Address and shipping information. Used to store additional addresses for a publisher.")]
			PublisherAddress = 7102, 
		
			[Label("Report")]
			[Description(@"Data summary in an easy-to-read layout.")]
			Report = 9100, 
		
			[Label("Replication Backlog")]
			[Description(@"Entity to hold replication backlog tasks. For internal use only.")]
			ReplicationBacklog = 1140, 
		
			[Label("Report Related Entity")]
			[Description(@"Entities related to a report. A report can be related to multiple entities.")]
			ReportRelatedEntity = 9101, 
		
			[Label("Report Related Category")]
			[Description(@"Categories related to a report. A report can be related to multiple categories.")]
			ReportRelatedCategory = 9102, 
		
			[Label("Relationship Attribute")]
			[Description(@"Stores relationship attributes mapping for Multi-predicate relationship")]
			RelationshipAttribute = 9814, 
		
			[Label("Relationship Entity")]
			[Description(@"")]
			RelationshipEntity = 9813, 
		
			[Label("Relationship Role Map")]
			[Description(@"Mapping of the primary associated objects between which the relationship role is valid.")]
			RelationshipRoleMap = 4501, 
		
			[Label("Relationship Role")]
			[Description(@"Relationship between an account or contact and an opportunity.")]
			RelationshipRole = 4500, 
		
			[Label("Resource Expansion")]
			[Description(@"Resource Expansions.")]
			ResourceExpansion = 4010, 
		
			[Label("resource group data source")]
			[Description(@"")]
			ResourceGroupDataSource = 10074, 
		
			[Label("Ribbon Client Metadata.")]
			[Description(@"A ribbon client metadata.")]
			RibbonClientMetadata = 4579, 
		
			[Label("Resource Specification")]
			[Description(@"Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.")]
			ResourceSpecification = 4006, 
		
			[Label("Report Visibility")]
			[Description(@"Area in which to show a report. A report can be shown in multiple areas.")]
			ReportVisibility = 9103, 
		
			[Label("Report Link")]
			[Description(@"Links and dependencies between reports. A report may drill through to another report, or it may have another report as a sub-report.")]
			ReportLink = 9104, 
		
			[Label("Scheduling Group")]
			[Description(@"Resource group or team whose members can be scheduled for a service.")]
			SchedulingGroup = 4005, 
		
			[Label("Resource")]
			[Description(@"User or facility/equipment that can be scheduled for a service.")]
			Resource = 4002, 
		
			[Label("Queue Item")]
			[Description(@"A specific item in a queue, such as a case record or an activity record.")]
			QueueItem = 2029, 
		
			[Label("Queue")]
			[Description(@"A list of records that require action, such as accounts, activities, and cases.")]
			Queue = 2020, 
		
			[Label("QueueMemberCount")]
			[Description(@"For internal use only.")]
			QueueMemberCount = 2024, 
		
			[Label("QueueItemCount")]
			[Description(@"For internal use only.")]
			QueueItemCount = 2023, 
		
			[Label("Penta Schedule")]
			[Description(@"")]
			PentaSchedule = 10110, 
		
			[Label("Penta Schedule Run")]
			[Description(@"")]
			PentaScheduleRun = 10140, 
		
			[Label("Quarterly Fiscal Calendar")]
			[Description(@"Quarterly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.")]
			QuarterlyFiscalCalendar = 2002, 
		
			[Label("Penta Scheduler Plugin")]
			[Description(@"")]
			PentaSchedulerPlugin = 10125, 
		
			[Label("Document Suggestions")]
			[Description(@"Document Suggestions")]
			DocumentSuggestions = 1189, 
		
			[Label("Rating Value")]
			[Description(@"A unique value associated with a rating model that allows providing a user friendly rating value.")]
			RatingValue = 1142, 
		
			[Label("Recurring Appointment")]
			[Description(@"The Master appointment of a recurring appointment series.")]
			RecurringAppointment = 4251, 
		
			[Label("Recurrence Rule")]
			[Description(@"Recurrence Rule represents the pattern of incidence of recurring entities.")]
			RecurrenceRule = 4250, 
		
			[Label("Quote Close")]
			[Description(@"Activity generated when a quote is closed.")]
			QuoteClose = 4211, 
		
			[Label("Quote")]
			[Description(@"Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.")]
			Quote = 1084, 
		
			[Label("Rating Model")]
			[Description(@"Represents a model to evaluate skills or other related entities.")]
			RatingModel = 1144, 
		
			[Label("Quote Product")]
			[Description(@"Product line item in a quote. The details include such information as product ID, description, quantity, and cost.")]
			QuoteProduct = 1085, 
		
			[Label("Partner Application")]
			[Description(@"Partner applications registered for this organization")]
			PartnerApplication = 1095, 
		
			[Label("Rich Text Attachment")]
			[Description(@"Image or file attached to a rich text field")]
			RichTextAttachment = 10040, 
		
			[Label("msdyn_relationshipinsightsunifiedconfig")]
			[Description(@"")]
			MsdynRelationshipinsightsunifiedconfig = 10084, 
		
			[Label("siconfig")]
			[Description(@"")]
			Siconfig = 10085, 
		
			[Label("salesinsightssettings")]
			[Description(@"Storing settings for studio feature")]
			Salesinsightssettings = 10091, 
		
			[Label("Profile Album")]
			[Description(@"Contains user profile images that are stored as attachments and displayed in posts.")]
			ProfileAlbum = 10101, 
		
			[Label("Playbook template")]
			[Description(@"Playbook templates contains the definition of the Playbook that helps to standardize a set of best practices or next best actions.")]
			PlaybookTemplate = 10081, 
		
			[Label("Post Rule Configuration")]
			[Description(@"Enable or disable system post rules for an entity for Activity Feeds and Yammer.")]
			PostRuleConfiguration = 10103, 
		
			[Label("Post Configuration")]
			[Description(@"Enable or disable entities for Activity Feeds and Yammer collaboration.")]
			PostConfiguration = 10102, 
		
			[Label("Suggested Activity")]
			[Description(@"")]
			SuggestedActivity = 10095, 
		
			[Label("Solution History Data Source")]
			[Description(@"")]
			SolutionHistoryDataSource = 10001, 
		
			[Label("Suggested Contact")]
			[Description(@"")]
			SuggestedContact = 10097, 
		
			[Label("Suggested Activity Data Source")]
			[Description(@"")]
			SuggestedActivityDataSource = 10096, 
		
			[Label("Solution Component Data Source")]
			[Description(@"")]
			SolutionComponentDataSource = 10012, 
		
			[Label("SI Key Value Config")]
			[Description(@"")]
			SIKeyValueConfig = 10086, 
		
			[Label("Solution History")]
			[Description(@"")]
			SolutionHistory = 10000, 
		
			[Label("Solution Component Summary")]
			[Description(@"")]
			SolutionComponentSummary = 10011, 
		
			[Label("Knowledge Article Template")]
			[Description(@"Organizational Knowledge Article Template for Internal and external creation of Knowledge Articles.")]
			KnowledgeArticleTemplate = 10047, 
		
			[Label("Knowledge Article Image")]
			[Description(@"")]
			KnowledgeArticleImage = 10044, 
		
			[Label("Knowledge Search Insight")]
			[Description(@"Knowledge Search Insight")]
			KnowledgeSearchInsight = 10046, 
		
			[Label("Knowledge Interaction Insight")]
			[Description(@"Knowledge Interaction Insight")]
			KnowledgeInteractionInsight = 10045, 
		
			[Label("Help Page")]
			[Description(@"")]
			HelpPage = 10031, 
		
			[Label("flowcardtype")]
			[Description(@"")]
			Flowcardtype = 10090, 
		
			[Label("Search provider")]
			[Description(@"")]
			SearchProvider = 10043, 
		
			[Label("icebreakersconfig")]
			[Description(@"")]
			Icebreakersconfig = 10100, 
		
			[Label("Playbook activity attribute")]
			[Description(@"Stores attribute names and values of the playbook activity.")]
			PlaybookActivityAttribute = 10078, 
		
			[Label("Playbook activity")]
			[Description(@"Stores the details of the activities to be created when a playbook is launched.")]
			PlaybookActivity = 10077, 
		
			[Label("Playbook")]
			[Description(@"Actual instance of a playbook template once it is launched.")]
			Playbook = 10080, 
		
			[Label("Playbook category")]
			[Description(@"List of categories for which a playbook can be created.")]
			PlaybookCategory = 10079, 
		
			[Label("msdyn_msteamssettingsv2")]
			[Description(@"")]
			MsdynMsteamssettingsv2 = 10108, 
		
			[Label("msdyn_msteamssetting")]
			[Description(@"")]
			MsdynMsteamssetting = 10107, 
		
			[Label("OData v4 Data Source")]
			[Description(@"Data sources used by the OData v4 data provider to access data from an external web service.")]
			ODataV4DataSource = 10027, 
		
			[Label("Notes analysis Config")]
			[Description(@"")]
			NotesAnalysisConfig = 10099, 
		
			[Label("Suggested contacts data source")]
			[Description(@"")]
			SuggestedContactsDataSource = 10098, 
		
			[Label("Opportunity Sales Process")]
			[Description(@"Opportunity Sales Process Business Process Flow")]
			OpportunitySalesProcess = 953, 
		
			[Label("Opportunity Product")]
			[Description(@"Association between an opportunity and a product.")]
			OpportunityProduct = 1083, 
		
			[Label("Order Close")]
			[Description(@"Activity generated automatically when an order is closed.")]
			OrderClose = 4209, 
		
			[Label("OptionSet")]
			[Description(@"")]
			OptionSet = 9809, 
		
			[Label("Opportunity")]
			[Description(@"Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.")]
			Opportunity = 3, 
		
			[Label("Offline Command Definition")]
			[Description(@"For internal use only.")]
			OfflineCommandDefinition = 9870, 
		
			[Label("OpportunityCompetitors")]
			[Description(@"")]
			OpportunityCompetitors = 25, 
		
			[Label("Opportunity Close")]
			[Description(@"Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.")]
			OpportunityClose = 4208, 
		
			[Label("Owner")]
			[Description(@"Group of undeleted system users and undeleted teams. Owners can be used to control access to specific objects.")]
			Owner = 7, 
		
			[Label("Organization Insights Notification")]
			[Description(@"Stores data regarding organization insights notification")]
			OrganizationInsightsNotification = 9690, 
		
			[Label("Package")]
			[Description(@"")]
			Package = 10007, 
		
			[Label("Owner Mapping")]
			[Description(@"In a data map, maps ownership data from the source file to Microsoft Dynamics 365.")]
			OwnerMapping = 4420, 
		
			[Label("Organization Statistic")]
			[Description(@"Statistics measuring the organization's usage of the Microsoft Dynamics 365 system over the past 24 hours.")]
			OrganizationStatistic = 4708, 
		
			[Label("Organization")]
			[Description(@"Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.")]
			Organization = 1019, 
		
			[Label("Organization Insights Metric")]
			[Description(@"Stores data regarding organization insights metric")]
			OrganizationInsightsMetric = 9699, 
		
			[Label("Organization UI")]
			[Description(@"Entity customizations including form layout and icons. Includes current and past versions.")]
			OrganizationUI = 1021, 
		
			[Label("Upgrade Version")]
			[Description(@"Information about upgrading from one release to the next release")]
			UpgradeVersion = 10070, 
		
			[Label("Upgrade Step")]
			[Description(@"One step during an upgrade, such as a single method or stored procedure.")]
			UpgradeStep = 10069, 
		
			[Label("Filter")]
			[Description(@"Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.")]
			Filter = 10105, 
		
			[Label("Wall View")]
			[Description(@"Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.")]
			WallView = 10104, 
		
			[Label("Tour")]
			[Description(@"")]
			Tour = 10141, 
		
			[Label("Microsoft Teams Collaboration entity")]
			[Description(@"Entity which stores collaboration data of Dynamics 365 with Microsoft Teams")]
			MicrosoftTeamsCollaborationEntity = 10109, 
		
			[Label("Upgrade Run")]
			[Description(@"Contains logging information about a run of a Package Deployer package that upgrades a solution")]
			UpgradeRun = 10068, 
		
			[Label("UntrackedAppointment")]
			[Description(@"")]
			UntrackedAppointment = 10094, 
		
			[Label("Notification")]
			[Description(@"For internal use only.")]
			Notification = 4110, 
		
			[Label("New Process")]
			[Description(@"New Process Business Process Flow")]
			NewProcess = 950, 
		
			[Label("Office Graph Document")]
			[Description(@"Office Graph Documents Description")]
			OfficeGraphDocument = 9950, 
		
			[Label("Office Document")]
			[Description(@"Used to store Office Documents in database in binary format.")]
			OfficeDocument = 4490, 
		
			[Label("MultiEntitySearch")]
			[Description(@"Multi Entity Search.")]
			MultiEntitySearch = 9910, 
		
			[Label("BotContent")]
			[Description(@"")]
			BotContent = 10032, 
		
			[Label("Navigation Setting")]
			[Description(@"Navigation Setting: A setting page or group of pages available for configuration within an app. A record representing a group of pages is regarded as the parent navigation setting of one or more other records. For internal use only.")]
			NavigationSetting = 9900, 
		
			[Label("Multi Select Option Value")]
			[Description(@"Multi Select Option Value")]
			MultiSelectOptionValue = 9912, 
		
			[Label("Ribbon Command")]
			[Description(@"Ribbon Commands - the command definition, rules, etc.")]
			RibbonCommand = 1116, 
		
			[Label("Email Template")]
			[Description(@"Template for an email message that contains the standard attributes of an email message.")]
			EmailTemplate = 2010, 
		
			[Label("Team template")]
			[Description(@"Team template for an entity enabled for automatically created access teams.")]
			TeamTemplate = 92, 
		
			[Label("Text Analytics Entity Mapping")]
			[Description(@"")]
			TextAnalyticsEntityMapping = 9945, 
		
			[Label("Territory")]
			[Description(@"Territory represents sales regions.")]
			Territory = 2013, 
		
			[Label("Team")]
			[Description(@"Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.")]
			Team = 9, 
		
			[Label("Task")]
			[Description(@"Generic activity representing work needed to be done.")]
			Task = 4212, 
		
			[Label("Team Sync-Attribute Mapping Profiles")]
			[Description(@"Team Sync-Attribute Mapping Profiles")]
			TeamSyncAttributeMappingProfiles = 1403, 
		
			[Label("Team Profiles")]
			[Description(@"Team Profiles")]
			TeamProfiles = 1203, 
		
			[Label("Text Analytics Topic")]
			[Description(@"Text Analytics Topics")]
			TextAnalyticsTopic = 9948, 
		
			[Label("Time Zone Rule")]
			[Description(@"Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone at a particular time period.")]
			TimeZoneRule = 4811, 
		
			[Label("Topic Model")]
			[Description(@"The model for automatic identification of topics using text analytics.")]
			TopicModel = 9944, 
		
			[Label("Topic History")]
			[Description(@"Entity for Topic History")]
			TopicHistory = 9946, 
		
			[Label("Time Stamp Date Mapping")]
			[Description(@"For internal use only.`")]
			TimeStampDateMapping = 9932, 
		
			[Label("Theme")]
			[Description(@"Information that's used to set custom visual theme options for client applications.")]
			Theme = 2015, 
		
			[Label("Time Zone Localized Name")]
			[Description(@"Localized name of the time zone.")]
			TimeZoneLocalizedName = 4812, 
		
			[Label("Time Zone Definition")]
			[Description(@"Time zone definition, including name and time zone code.")]
			TimeZoneDefinition = 4810, 
		
			[Label("Tracking information for deleted entities")]
			[Description(@"For internal use only.")]
			TrackingInformationForDeletedEntities = 35, 
		
			[Label("Subscription Synchronization Information")]
			[Description(@"For internal use only.")]
			SubscriptionSynchronizationInformation = 33, 
		
			[Label("Sync Attribute Mapping")]
			[Description(@"Group of Sync-Attribute Mappings used to provide Attribute mappings during sync for a particular user")]
			SyncAttributeMapping = 1401, 
		
			[Label("SuggestionCardTemplate")]
			[Description(@"Templates for Suggestion Card in Grid")]
			SuggestionCardTemplate = 1190, 
		
			[Label("Subscription Statistic Outlook")]
			[Description(@"Subscription Statistic Outlook")]
			SubscriptionStatisticOutlook = 46, 
		
			[Label("Subscription Statistic Offline")]
			[Description(@"Subscription Statistic Offline")]
			SubscriptionStatisticOffline = 45, 
		
			[Label("Subscription Sync Entry Outlook")]
			[Description(@"Used for outlook sync, internal use only.")]
			SubscriptionSyncEntryOutlook = 48, 
		
			[Label("Subscription Sync Entry Offline")]
			[Description(@"Used for offline sync, internal use only.")]
			SubscriptionSyncEntryOffline = 47, 
		
			[Label("SystemUser BusinessUnit Entity Map")]
			[Description(@"Stores mapping attributes for business units.")]
			SystemUserBusinessUnitEntityMap = 42, 
		
			[Label("User")]
			[Description(@"Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.")]
			User = 8, 
		
			[Label("System User Principal")]
			[Description(@"For internal use only.")]
			SystemUserPrincipal = 14, 
		
			[Label("System User Manager Map")]
			[Description(@"For internal use only.")]
			SystemUserManagerMap = 51, 
		
			[Label("Sync Error")]
			[Description(@"Failure reason and other detailed information for a record that failed to sync.")]
			SyncError = 9869, 
		
			[Label("Sync Attribute Mapping Profile")]
			[Description(@"Profile which defines sync attribute mapping")]
			SyncAttributeMappingProfile = 1400, 
		
			[Label("System Form")]
			[Description(@"Organization-owned entity customizations including form layout and dashboards.")]
			SystemForm = 1030, 
		
			[Label("System Application Metadata")]
			[Description(@"For internal use only.")]
			SystemApplicationMetadata = 7000, 
		
			[Label("Topic Model Configuration")]
			[Description(@"Configuration settings for identification of topics using text analytics.")]
			TopicModelConfiguration = 9942, 
		
			[Label("User Settings")]
			[Description(@"User's preferred settings.")]
			UserSettings = 150, 
		
			[Label("User Search Facet")]
			[Description(@"")]
			UserSearchFacet = 52, 
		
			[Label("Web Resource")]
			[Description(@"Data equivalent to files used in Web development. Web resources provide client-side components that are used to provide custom user interface elements.")]
			WebResource = 9333, 
		
			[Label("Virtual Resource Group Resource")]
			[Description(@"")]
			VirtualResourceGroupResource = 10075, 
		
			[Label("User Mapping")]
			[Description(@"User Mapping")]
			UserMapping = 2016, 
		
			[Label("User Dashboard")]
			[Description(@"User-owned dashboards.")]
			UserDashboard = 1031, 
		
			[Label("User Chart")]
			[Description(@"Chart attached to an entity.")]
			UserChart = 1112, 
		
			[Label("Saved View")]
			[Description(@"Saved database query that is owned by a user.")]
			SavedView = 4230, 
		
			[Label("Process Dependency")]
			[Description(@"Dependencies for a process.")]
			ProcessDependency = 4704, 
		
			[Label("Workflow Binary")]
			[Description(@"")]
			WorkflowBinary = 10029, 
		
			[Label("Workflow Wait Subscription")]
			[Description(@"For internal use only.")]
			WorkflowWaitSubscription = 4702, 
		
			[Label("Process Log")]
			[Description(@"Log used to track process execution.")]
			ProcessLog = 4706, 
		
			[Label("Web Wizard Access Privilege")]
			[Description(@"Privilege needed to access a Web-based wizard.")]
			WebWizardAccessPrivilege = 4803, 
		
			[Label("Web Wizard")]
			[Description(@"Definition for a Web-based wizard.")]
			WebWizard = 4800, 
		
			[Label("Process")]
			[Description(@"Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.")]
			Process = 4703, 
		
			[Label("Wizard Page")]
			[Description(@"Page in a Web-based wizard.")]
			WizardPage = 4802, 
		
			[Label("Transformation Mapping")]
			[Description(@"In a data map, maps the transformation of source attributes to Microsoft Dynamics 365 attributes.")]
			TransformationMapping = 4426, 
		
			[Label("Currency")]
			[Description(@"Currency in which a financial transaction is carried out.")]
			Currency = 9105, 
		
			[Label("Translation Process")]
			[Description(@"Translation Process Business Process Flow")]
			TranslationProcess = 951, 
		
			[Label("Transformation Parameter Mapping")]
			[Description(@"In a data map, defines parameters for a transformation.")]
			TransformationParameterMapping = 4427, 
		
			[Label("Trace Association")]
			[Description(@"Represents the objects with which a trace record is associated. For internal use only.")]
			TraceAssociation = 8051, 
		
			[Label("Topic Model Execution History")]
			[Description(@"Entity for Topic Model Execution History")]
			TopicModelExecutionHistory = 9943, 
		
			[Label("Trace Regarding")]
			[Description(@"Represents which object a trace record is regarding. For internal use only.")]
			TraceRegarding = 8052, 
		
			[Label("Trace")]
			[Description(@"A trace log.")]
			Trace = 8050, 
		
			[Label("User Entity Instance Data")]
			[Description(@"Per User item instance data")]
			UserEntityInstanceData = 2501, 
		
			[Label("User Application Metadata")]
			[Description(@"For internal use only.")]
			UserApplicationMetadata = 7001, 
		
			[Label("User Fiscal Calendar")]
			[Description(@"Custom fiscal calendar used for tracking sales quotas.")]
			UserFiscalCalendar = 1086, 
		
			[Label("User Entity UI Settings")]
			[Description(@"Stores user settings for entity views.")]
			UserEntityUISettings = 2500, 
		
			[Label("UntrackedEmail")]
			[Description(@"Activity that is delivered using UntrackedEmail protocols.")]
			UntrackedEmail = 4220, 
		
			[Label("Unresolved Address")]
			[Description(@"For internal use only.")]
			UnresolvedAddress = 2012, 
		
			[Label("Unit Group")]
			[Description(@"Grouping of units.")]
			UnitGroup = 1056, 
		
			[Label("Unit")]
			[Description(@"Unit of measure.")]
			Unit = 1055, 
		
			[Label("Subscription Manually Tracked Object")]
			[Description(@"For internal use only.")]
			SubscriptionManuallyTrackedObject = 37, 
		
			[Label("System Chart")]
			[Description(@"System chart attached to an entity.")]
			SystemChart = 1111, 
		
			[Label("View")]
			[Description(@"Saved query against the database.")]
			View = 1039, 
		
			[Label("Sdk Message Filter")]
			[Description(@"Filter that defines which SDK messages are valid for each type of entity.")]
			SdkMessageFilter = 4607, 
		
			[Label("Sdk Message")]
			[Description(@"Message that is supported by the SDK.")]
			SdkMessage = 4606, 
		
			[Label("Order Product")]
			[Description(@"Line item in a sales order.")]
			OrderProduct = 1089, 
		
			[Label("Order")]
			[Description(@"Quote that has been accepted.")]
			Order = 1088, 
		
			[Label("Saved Organization Insights Configuration")]
			[Description(@"Saved configuration for the organization insights")]
			SavedOrganizationInsightsConfiguration = 1309, 
		
			[Label("Sales Process Instance")]
			[Description(@"Instance of a sales process.")]
			SalesProcessInstance = 32, 
		
			[Label("Sdk Message Request Field")]
			[Description(@"For internal use only.")]
			SdkMessageRequestField = 4614, 
		
			[Label("Sdk Message Request")]
			[Description(@"For internal use only.")]
			SdkMessageRequest = 4609, 
		
			[Label("Sdk Message Response Field")]
			[Description(@"For internal use only.")]
			SdkMessageResponseField = 4611, 
		
			[Label("Sdk Message Response")]
			[Description(@"For internal use only.")]
			SdkMessageResponse = 4610, 
		
			[Label("Sdk Message Processing Step")]
			[Description(@"Stage in the execution pipeline that a plug-in is to execute.")]
			SdkMessageProcessingStep = 4608, 
		
			[Label("Sdk Message Pair")]
			[Description(@"For internal use only.")]
			SdkMessagePair = 4613, 
		
			[Label("Sdk Message Processing Step Secure Configuration")]
			[Description(@"Non-public custom configuration that is passed to a plug-in's constructor.")]
			SdkMessageProcessingStepSecureConfiguration = 4616, 
		
			[Label("Sdk Message Processing Step Image")]
			[Description(@"Copy of an entity's attributes before or after the core system operation.")]
			SdkMessageProcessingStepImage = 4615, 
		
			[Label("Ribbon Tab To Command Mapping")]
			[Description(@"A mapping between Tab Ids, and the Commands within those tabs.")]
			RibbonTabToCommandMapping = 1113, 
		
			[Label("Ribbon Rule")]
			[Description(@"Ribbon rule definitions, used to enable and disable, show and hide ribbon elements.")]
			RibbonRule = 1117, 
		
			[Label("Role Template")]
			[Description(@"Template for a role. Defines initial attributes that will be used when creating a new role.")]
			RoleTemplate = 1037, 
		
			[Label("Security Role")]
			[Description(@"Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.")]
			SecurityRole = 1036, 
		
			[Label("Application Ribbons")]
			[Description(@"Ribbon customizations for the application ribbon and entity ribbon templates.")]
			ApplicationRibbons = 1120, 
		
			[Label("Ribbon Context Group")]
			[Description(@"Groupings of contextual tabs.")]
			RibbonContextGroup = 1115, 
		
			[Label("Ribbon Metadata To Process")]
			[Description(@"Container for Ribbon Metadata To Process")]
			RibbonMetadataToProcess = 9880, 
		
			[Label("Ribbon Difference")]
			[Description(@"All layout customizations to be applied to the ribbons, which contain only the differences from the base ribbon.")]
			RibbonDifference = 1130, 
		
			[Label("RuntimeDependency")]
			[Description(@"Form Level dependencies in CRM.")]
			RuntimeDependency = 7200, 
		
			[Label("Rule Item")]
			[Description(@"Please provide the description for entity")]
			RuleItem = 8199, 
		
			[Label("Sales Attachment")]
			[Description(@"Item in the sales literature collection.")]
			SalesAttachment = 1070, 
		
			[Label("Sales Literature")]
			[Description(@"Storage of sales literature, which may contain one or more documents.")]
			SalesLiterature = 1038, 
		
			[Label("Rollup Job")]
			[Description(@"Stores rollup jobs.")]
			RollupJob = 9511, 
		
			[Label("Rollup Field")]
			[Description(@"Field to be rolled up to calculate the actual and in-progress values against the goal.")]
			RollupField = 9604, 
		
			[Label("Routing Rule Set")]
			[Description(@"Define Routing Rule to route cases to right people at the right time")]
			RoutingRuleSet = 8181, 
		
			[Label("Rollup Properties")]
			[Description(@"Stores properties related to rollup fields.")]
			RollupProperties = 9510, 
		
			[Label("Semiannual Fiscal Calendar")]
			[Description(@"Calendar representing the semi-annual span of time during which the financial activities of an organization are calculated.")]
			SemiannualFiscalCalendar = 2001, 
		
			[Label("Solution Component Attribute Configuration")]
			[Description(@"")]
			SolutionComponentAttributeConfiguration = 10002, 
		
			[Label("Solution Component")]
			[Description(@"A component of a CRM solution.")]
			SolutionComponent = 7103, 
		
			[Label("Solution Component Definition")]
			[Description(@"Contains all the information required to process a solution aware entity")]
			SolutionComponentDefinition = 7104, 
		
			[Label("Solution Component Configuration")]
			[Description(@"")]
			SolutionComponentConfiguration = 10003, 
		
			[Label("SocialInsightsConfiguration")]
			[Description(@"Configuration for the social insights.")]
			SocialInsightsConfiguration = 1300, 
		
			[Label("Social Activity")]
			[Description(@"For internal use only.")]
			SocialActivity = 4216, 
		
			[Label("Solution")]
			[Description(@"A solution which contains CRM customizations.")]
			Solution = 7100, 
		
			[Label("Social Profile")]
			[Description(@"This entity is used to store social profile information of its associated account and contacts on different social channels.")]
			SocialProfile = 99, 
		
			[Label("Subject")]
			[Description(@"Information regarding subjects available in the system.")]
			Subject = 129, 
		
			[Label("String Map")]
			[Description(@"Mapping between strings.")]
			StringMap = 1043, 
		
			[Label("Subscription Clients")]
			[Description(@"For internal use only.")]
			SubscriptionClients = 1072, 
		
			[Label("Subscription")]
			[Description(@"For internal use only.")]
			Subscription = 29, 
		
			[Label("SolutionHistoryData")]
			[Description(@"solution history data")]
			SolutionHistoryData = 9890, 
		
			[Label("Solution Component Relationship Configuration")]
			[Description(@"")]
			SolutionComponentRelationshipConfiguration = 10004, 
		
			[Label("Status Map")]
			[Description(@"Mapping between statuses.")]
			StatusMap = 1075, 
		
			[Label("StageSolutionUpload")]
			[Description(@"")]
			StageSolutionUpload = 10009, 
		
			[Label("Setting Definition")]
			[Description(@"Contains Setting Definitions")]
			SettingDefinition = 10025, 
		
			[Label("Service Plan")]
			[Description(@"Service Plan")]
			ServicePlan = 101, 
		
			[Label("Sharepoint Document")]
			[Description(@"Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.")]
			SharepointDocument = 9507, 
		
			[Label("SharePoint Data")]
			[Description(@"SharePoint's Data Corresponding to a user , Record , Location and Page")]
			SharePointData = 9509, 
		
			[Label("Service Activity")]
			[Description(@"Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.")]
			ServiceActivity = 4214, 
		
			[Label("Service")]
			[Description(@"Activity that represents work done to satisfy a customer's need.")]
			Service = 4001, 
		
			[Label("Service Endpoint")]
			[Description(@"Service endpoint that can be contacted.")]
			ServiceEndpoint = 4618, 
		
			[Label("Service Contract Contact")]
			[Description(@"Item in a Service contract.")]
			ServiceContractContact = 20, 
		
			[Label("SLA")]
			[Description(@"Contains information about the tracked service-level KPIs for cases that belong to different customers.")]
			SLA = 9750, 
		
			[Label("Site Map")]
			[Description(@"XML data used to control the application navigation pane.")]
			SiteMap = 4709, 
		
			[Label("SLA KPI Instance")]
			[Description(@"Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case")]
			SLAKPIInstance = 9752, 
		
			[Label("SLA Item")]
			[Description(@"Contains information about a tracked support KPI for a specific customer.")]
			SLAItem = 9751, 
		
			[Label("SharePoint Site")]
			[Description(@"SharePoint site from where documents can be managed in Microsoft Dynamics 365.")]
			SharePointSite = 9502, 
		
			[Label("Document Location")]
			[Description(@"Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics 365.")]
			DocumentLocation = 9508, 
		
			[Label("Site")]
			[Description(@"Location or branch office where an organization does business. An organization can have multiple sites.")]
			Site = 4009, 
		
			[Label("Similarity Rule")]
			[Description(@"")]
			SimilarityRule = 9951, 
		
			[Label("Knowledge FederatedArticle Incident")]
			[Description(@"")]
			KnowledgeFederatedArticleIncident = 10042, 
		
			[Label("Competitor Product")]
			[Description(@"Association between a competitor and a product offered by the competitor.")]
			CompetitorProduct = 1006, 
		
			[Label("Competitor Address")]
			[Description(@"Additional addresses for a competitor. The first two addresses are stored in the competitor object.")]
			CompetitorAddress = 1004, 
		
			[Label("Process Configuration")]
			[Description(@"For internal use only.")]
			ProcessConfiguration = 9650, 
		
			[Label("CompetitorSalesLiterature")]
			[Description(@"")]
			CompetitorSalesLiterature = 26, 
		
			[Label("Column Mapping")]
			[Description(@"Mapping for columns in a data map.")]
			ColumnMapping = 4417, 
		
			[Label("Client update")]
			[Description(@"Microsoft Dynamics 365 client for Outlook offline database update.")]
			ClientUpdate = 36, 
		
			[Label("Competitor")]
			[Description(@"Business competing for the sale represented by a lead or opportunity.")]
			Competitor = 123, 
		
			[Label("Commitment")]
			[Description(@"For internal use only.")]
			Commitment = 4215, 
		
			[Label("Resource Group")]
			[Description(@"Group or collection of people, equipment, and/or facilities that can be scheduled.")]
			ResourceGroup = 4007, 
		
			[Label("Connector")]
			[Description(@"Connector Entity to support Solutioning Integration")]
			Connector = 372, 
		
			[Label("ContactInvoices")]
			[Description(@"")]
			ContactInvoices = 17, 
		
			[Label("Contact")]
			[Description(@"Person with whom a business unit has a relationship, such as customer, supplier, and colleague.")]
			Contact = 2, 
		
			[Label("Connection Reference")]
			[Description(@"")]
			ConnectionReference = 10030, 
		
			[Label("Connection")]
			[Description(@"Relationship between two entities.")]
			Connection = 3234, 
		
			[Label("Connection Role Object Type Code")]
			[Description(@"Specifies the entity type that can play specific role in a connection.")]
			ConnectionRoleObjectTypeCode = 3233, 
		
			[Label("Connection Role")]
			[Description(@"Role describing a relationship between a two records.")]
			ConnectionRole = 3231, 
		
			[Label("CascadeGrantRevokeAccessVersionTracker")]
			[Description(@"")]
			CascadeGrantRevokeAccessVersionTracker = 10019, 
		
			[Label("CascadeGrantRevokeAccessRecordsTracker")]
			[Description(@"")]
			CascadeGrantRevokeAccessRecordsTracker = 10018, 
		
			[Label("Catalog Assignment")]
			[Description(@"Entity for assigning records to a specific catalog")]
			CatalogAssignment = 10049, 
		
			[Label("Catalog")]
			[Description(@"Entity for cataloging records to make it easier for your customers to find them on portals and through search.")]
			Catalog = 10048, 
		
			[Label("Canvas App")]
			[Description(@"An application built through a canvas-based editing experience.")]
			CanvasApp = 300, 
		
			[Label("Campaign Response")]
			[Description(@"Response from an existing or a potential new customer for a campaign.")]
			CampaignResponse = 4401, 
		
			[Label("Action Card Type")]
			[Description(@"To provide master data for the card types list. For internal use only")]
			ActionCardType = 9983, 
		
			[Label("CanvasApp Extended Metadata")]
			[Description(@"Holds extended metadata values for canvas apps that are not solution aware")]
			CanvasAppExtendedMetadata = 10026, 
		
			[Label("Channel Property Group")]
			[Description(@"Group or collection of channel properties provided by the external channel for a Microsoft Dynamics 365 activity.")]
			ChannelPropertyGroup = 1234, 
		
			[Label("Channel Property")]
			[Description(@"Instance of a channel property containing its name and corresponding data type.")]
			ChannelProperty = 1236, 
		
			[Label("Child Incident Count")]
			[Description(@"For internal use only.")]
			ChildIncidentCount = 113, 
		
			[Label("Characteristic")]
			[Description(@"Skills, education and certifications of resources.")]
			Characteristic = 1141, 
		
			[Label("Channel Access Profile")]
			[Description(@"Information about permissions needed to access Dynamics 365 through external channels.For internal use only")]
			ChannelAccessProfile = 3005, 
		
			[Label("Category")]
			[Description(@"Entity for categorizing records to make it easier for your customers to find them on portals and through search.")]
			Category = 9959, 
		
			[Label("Channel Access Profile Rule Item")]
			[Description(@"Defines the rule items of a profile rule set for the automated profile association.For internal use only")]
			ChannelAccessProfileRuleItem = 9401, 
		
			[Label("Channel Access Profile Rule")]
			[Description(@"Defines the rules for automatically associating channel access profiles to external party records.For internal use only")]
			ChannelAccessProfileRule = 9400, 
		
			[Label("ContactLeads")]
			[Description(@"")]
			ContactLeads = 22, 
		
			[Label("Data Performance Dashboard")]
			[Description(@"Data Performance Dashboard.")]
			DataPerformanceDashboard = 4450, 
		
			[Label("Data Lake Workspace Permission")]
			[Description(@"")]
			DataLakeWorkspacePermission = 10016, 
		
			[Label("Dependency")]
			[Description(@"A component dependency in CRM.")]
			Dependency = 7105, 
		
			[Label("DelveActionHub")]
			[Description(@"Delve Action Hubs Description")]
			DelveActionHub = 9961, 
		
			[Label("Data Lake Folder")]
			[Description(@"A folder is a place to store data in Azure Data Lake.")]
			DataLakeFolder = 10013, 
		
			[Label("Customer Relationship")]
			[Description(@"Relationship between a customer and a partner in which either can be an account or contact.")]
			CustomerRelationship = 4502, 
		
			[Label("Data Lake Workspace")]
			[Description(@"A workspace is a place to store data in Azure Data Lake.")]
			DataLakeWorkspace = 10015, 
		
			[Label("Data Lake Folder Permission")]
			[Description(@"")]
			DataLakeFolderPermission = 10014, 
		
			[Label("Display String Map")]
			[Description(@"Maps customized display strings to entities.")]
			DisplayStringMap = 4101, 
		
			[Label("Display String")]
			[Description(@"Customized messages for an entity that has been renamed.")]
			DisplayString = 4102, 
		
			[Label("Document Template")]
			[Description(@"Used to store Document Templates in database in binary format.")]
			DocumentTemplate = 9940, 
		
			[Label("Indexed Article")]
			[Description(@"Article indexed for search purposes.")]
			IndexedArticle = 126, 
		
			[Label("Dependency Node")]
			[Description(@"The representation of a component dependency node in CRM.")]
			DependencyNode = 7106, 
		
			[Label("Dependency Feature")]
			[Description(@"A dependency feature.")]
			DependencyFeature = 7108, 
		
			[Label("Discount List")]
			[Description(@"Type of discount specified as either a percentage or an amount.")]
			DiscountList = 1080, 
		
			[Label("Discount")]
			[Description(@"Price reduction made from the list price of a product or service based on the quantity purchased.")]
			Discount = 1013, 
		
			[Label("ConversationTranscript")]
			[Description(@"Contains the transcripts of conversations between participants such as customers, Virtual Agents or Human agents.")]
			ConversationTranscript = 10033, 
		
			[Label("Contract Template")]
			[Description(@"Template for a contract containing the standard attributes of a contract.")]
			ContractTemplate = 2011, 
		
			[Label("Record Creation and Update Rule Item")]
			[Description(@"Defines the individual conditions required for creating records automatically.")]
			RecordCreationAndUpdateRuleItem = 9301, 
		
			[Label("Record Creation and Update Rule")]
			[Description(@"Defines the settings for automatic record creation.")]
			RecordCreationAndUpdateRule = 9300, 
		
			[Label("ContactQuotes")]
			[Description(@"")]
			ContactQuotes = 18, 
		
			[Label("ContactOrders")]
			[Description(@"")]
			ContactOrders = 19, 
		
			[Label("Contract Line")]
			[Description(@"Line item in a contract that specifies the type of service a customer is entitled to.")]
			ContractLine = 1011, 
		
			[Label("Contract")]
			[Description(@"Agreement to provide customer service during a specified amount of time or number of cases.")]
			Contract = 1010, 
		
			[Label("Custom Control Resource")]
			[Description(@"Custom Control Resource Id")]
			CustomControlResource = 9754, 
		
			[Label("Custom Control Default Config")]
			[Description(@"For internal use only.")]
			CustomControlDefaultConfig = 9755, 
		
			[Label("Opportunity Relationship")]
			[Description(@"Relationship between an account or contact and an opportunity.")]
			OpportunityRelationship = 4503, 
		
			[Label("Address")]
			[Description(@"Address and shipping information. Used to store additional addresses for an account or contact.")]
			Address = 1071, 
		
			[Label("Custom API Request Parameter")]
			[Description(@"Entity that defines a request parameter for a custom API")]
			CustomAPIRequestParameter = 10052, 
		
			[Label("Custom API")]
			[Description(@"Entity that defines a custom API")]
			CustomAPI = 10051, 
		
			[Label("Custom Control")]
			[Description(@"For internal use only.")]
			CustomControl = 9753, 
		
			[Label("Custom API Response Property")]
			[Description(@"Entity that defines a response property for a custom API")]
			CustomAPIResponseProperty = 10053, 
		
			[Label("Campaign Item")]
			[Description(@"Work item in a campaign, a list or sales literature.")]
			CampaignItem = 4403, 
		
			[Label("Model-Driven App Component Node's Edge")]
			[Description(@"Contains Model-Driven App Component Node's Edge Information.")]
			ModelDrivenAppComponentNodesEdge = 10022, 
		
			[Label("App Module Component")]
			[Description(@"A component available in a business app such as entity, dashboard, form, view, chart, and business process.")]
			AppModuleComponent = 9007, 
		
			[Label("AppModule Metadata")]
			[Description(@"For internal use only.")]
			AppModuleMetadata = 8700, 
		
			[Label("Model-Driven App Component Node")]
			[Description(@"Contains Model-Driven App Component Node Information")]
			ModelDrivenAppComponentNode = 10023, 
		
			[Label("Model-Driven App Element")]
			[Description(@"Associates a model-driven app with its components.")]
			ModelDrivenAppElement = 10021, 
		
			[Label("App Config Master")]
			[Description(@"Contains the master list of all properties that can be customized for apps in Dynamics 365. For internal use only.")]
			AppConfigMaster = 9011, 
		
			[Label("Model-driven App")]
			[Description(@"A role-based, modular business app that provides task-based functionality for a particular area of work.")]
			ModeldrivenApp = 9006, 
		
			[Label("Application File")]
			[Description(@"Files used by the application")]
			ApplicationFile = 4707, 
		
			[Label("System Job")]
			[Description(@"Process whose execution can proceed independently or in the background.")]
			SystemJob = 4700, 
		
			[Label("Model-Driven App Setting")]
			[Description(@"Holds the value for the associated App Setting Definition.")]
			ModelDrivenAppSetting = 10024, 
		
			[Label("Attribute")]
			[Description(@"")]
			Attribute = 9808, 
		
			[Label("Attachment")]
			[Description(@"Attachment for an email activity.")]
			Attachment = 1002, 
		
			[Label("AppModule Metadata Async Operation")]
			[Description(@"For internal use only.")]
			AppModuleMetadataAsyncOperation = 8702, 
		
			[Label("AppModule Metadata Dependency")]
			[Description(@"For internal use only.")]
			AppModuleMetadataDependency = 8701, 
		
			[Label("Appointment")]
			[Description(@"Commitment representing a time interval with start/end times and duration.")]
			Appointment = 4201, 
		
			[Label("App Module Roles")]
			[Description(@"Security roles that have access to a business app.")]
			AppModuleRoles = 9009, 
		
			[Label("ActionCardUserState")]
			[Description(@"")]
			ActionCardUserState = 9968, 
		
			[Label("Action Card User Settings")]
			[Description(@"Stores user settings for action cards")]
			ActionCardUserSettings = 9973, 
		
			[Label("Activity monitor")]
			[Description(@"Entity that tracks ARC runtime information.")]
			ActivityMonitor = 10071, 
		
			[Label("Attachment")]
			[Description(@"MIME attachment for an activity.")]
			Attachment2 = 1001, 
		
			[Label("AccountLeads")]
			[Description(@"description.")]
			AccountLeads = 16, 
		
			[Label("Account")]
			[Description(@"Business that represents a customer or potential customer. The company that is billed in business transactions.")]
			Account = 1, 
		
			[Label("Action Card")]
			[Description(@"Action card entity to show action cards.")]
			ActionCard = 9962, 
		
			[Label("ACIViewMapper")]
			[Description(@"Customized messages for an entity that has been renamed.")]
			ACIViewMapper = 8040, 
		
			[Label("Annual Fiscal Calendar")]
			[Description(@"Year long fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.")]
			AnnualFiscalCalendar = 2000, 
		
			[Label("Note")]
			[Description(@"Note that is attached to one or more objects, including other notes.")]
			Note = 5, 
		
			[Label("App Configuration Instance")]
			[Description(@"Contains a property or a list of properties from the app configuration master list that can be customized for any app in Dynamics 365. For internal use only.")]
			AppConfigurationInstance = 9013, 
		
			[Label("App Configuration")]
			[Description(@"Contains a mapping between an app configuration instance and an app, which defines the properties that can be customized for the app. Optionally, also contains navigation setting for an app. For internal use only.")]
			AppConfiguration = 9012, 
		
			[Label("Activity")]
			[Description(@"Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.")]
			Activity = 4200, 
		
			[Label("Activity Party")]
			[Description(@"Person or group associated with an activity. An activity can have multiple activity parties.")]
			ActivityParty = 135, 
		
			[Label("Advanced Similarity Rule")]
			[Description(@"A text match rule identifies similar records using keywords and key phrases determined with text analytics")]
			AdvancedSimilarityRule = 9949, 
		
			[Label("admin_settings_entity")]
			[Description(@"")]
			AdminSettingsEntity = 10083, 
		
			[Label("Image Attribute Configuration")]
			[Description(@"Store configuration for each image attribute")]
			ImageAttributeConfiguration = 431, 
		
			[Label("Business Data Localized Label")]
			[Description(@"Business Data Localized Label")]
			BusinessDataLocalizedLabel = 4232, 
		
			[Label("Bulk Operation Log")]
			[Description(@"Log used to track bulk operation execution, successes, and failures.")]
			BulkOperationLog = 4405, 
		
			[Label("Business Unit")]
			[Description(@"Business, division, or department in the Microsoft Dynamics 365 database.")]
			BusinessUnit = 10, 
		
			[Label("Business Process Flow Instance")]
			[Description(@"Active path associated with every Business Process Flow instance")]
			BusinessProcessFlowInstance = 4725, 
		
			[Label("Bulk Delete Failure")]
			[Description(@"Record that was not deleted during a bulk deletion job.")]
			BulkDeleteFailure = 4425, 
		
			[Label("Chatbot subcomponent")]
			[Description(@"Holds key authoring components of a Chatbot such a topics, entities, variables, etc.")]
			ChatbotSubcomponent = 10035, 
		
			[Label("Quick Campaign")]
			[Description(@"System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.")]
			QuickCampaign = 4406, 
		
			[Label("Bulk Delete Operation")]
			[Description(@"User-submitted bulk deletion job.")]
			BulkDeleteOperation = 4424, 
		
			[Label("Campaign")]
			[Description(@"Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.")]
			Campaign = 4400, 
		
			[Label("Callback Registration")]
			[Description(@"Callback Registration that stores configuration.")]
			CallbackRegistration = 301, 
		
			[Label("Campaign Activity Item")]
			[Description(@"Work item of a campaign activity, such as a list or sales literature.")]
			CampaignActivityItem = 4404, 
		
			[Label("Campaign Activity")]
			[Description(@"Task performed, or to be performed, by a user for planning or running a campaign.")]
			CampaignActivity = 4402, 
		
			[Label("Announcement")]
			[Description(@"Announcement associated with an organization.")]
			Announcement = 132, 
		
			[Label("Business Unit Map")]
			[Description(@"Stores mapping attributes for business units.")]
			BusinessUnitMap = 6, 
		
			[Label("Calendar Rule")]
			[Description(@"Defines free/busy times for a service and for resources or resource groups, such as working, non-working, vacation, and blocked.")]
			CalendarRule = 4004, 
		
			[Label("Calendar")]
			[Description(@"Calendar used by the scheduling system to define when an appointment or activity is to occur.")]
			Calendar = 4003, 
		
			[Label("Azure Service Connection")]
			[Description(@"Stores connection information for an Azure service")]
			AzureServiceConnection = 9936, 
		
			[Label("Available Times Data Source")]
			[Description(@"")]
			AvailableTimesDataSource = 10073, 
		
			[Label("Bookable Resource Booking")]
			[Description(@"Represents the line details of a resource booking.")]
			BookableResourceBooking = 1145, 
		
			[Label("Bookable Resource")]
			[Description(@"Resource that has capacity which can be allocated to work.")]
			BookableResource = 1150, 
		
			[Label("Auditing")]
			[Description(@"Track changes to records for analysis, record keeping, and compliance.")]
			Auditing = 4567, 
		
			[Label("Attribute Map")]
			[Description(@"Represents a mapping between attributes where the attribute values should be copied from a record into the form of a new related record.")]
			AttributeMap = 4601, 
		
			[Label("Available Times")]
			[Description(@"")]
			AvailableTimes = 10072, 
		
			[Label("Authorization Server")]
			[Description(@"Authorization servers that trust this organization")]
			AuthorizationServer = 1094, 
		
			[Label("Bookable Resource Group")]
			[Description(@"Associates resources with resource groups that they are a member of.")]
			BookableResourceGroup = 1151, 
		
			[Label("Bookable Resource Characteristic")]
			[Description(@"Associates resources with their characteristics and specifies the proficiency level of a resource for that characteristic.")]
			BookableResourceCharacteristic = 1148, 
		
			[Label("Chatbot")]
			[Description(@"Represents a Power Virtual Agents Chatbot. https://powerva.microsoft.com/")]
			Chatbot = 10034, 
		
			[Label("Booking Status")]
			[Description(@"Allows creation of multiple sub statuses mapped to a booking status option.")]
			BookingStatus = 1152, 
		
			[Label("Bookable Resource Booking Header")]
			[Description(@"Reservation entity representing the summary of the associated resource bookings.")]
			BookableResourceBookingHeader = 1146, 
		
			[Label("Bookable Resource Booking to Exchange Id Mapping")]
			[Description(@"The mapping used to keep track of the IDs for items synced between Dynamics 365 Bookable Resource Booking and Exchange.")]
			BookableResourceBookingToExchangeIdMapping = 4421, 
		
			[Label("Bookable Resource Category Assn")]
			[Description(@"Association entity to model the categorization of resources.")]
			BookableResourceCategoryAssn = 1149, 
		
			[Label("Bookable Resource Category")]
			[Description(@"Categorize resources that have capacity into categories such as roles.")]
			BookableResourceCategory = 1147, 
		
			[Label("Duplicate Record")]
			[Description(@"Potential duplicate record.")]
			DuplicateRecord = 4415, 
		
			[Label("License")]
			[Description(@"Stores information about a Microsoft CRM license.")]
			License = 2027, 
		
			[Label("Letter")]
			[Description(@"Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.")]
			Letter = 4207, 
		
			[Label("Marketing List Member")]
			[Description(@"Item in a marketing list.")]
			MarketingListMember = 4301, 
		
			[Label("Marketing List")]
			[Description(@"Group of existing or potential customers created for a marketing campaign or other sales purposes.")]
			MarketingList = 4300, 
		
			[Label("LeadCompetitors")]
			[Description(@"")]
			LeadCompetitors = 24, 
		
			[Label("Lead Address")]
			[Description(@"Address information for a lead.")]
			LeadAddress = 1017, 
		
			[Label("Lead To Opportunity Sales Process")]
			[Description(@"Lead To Opportunity Sales Process Business Process Flow")]
			LeadToOpportunitySalesProcess = 954, 
		
			[Label("LeadProduct")]
			[Description(@"")]
			LeadProduct = 27, 
		
			[Label("Mailbox Tracking Category")]
			[Description(@"Stores data about what categories for a mailbox are tracked")]
			MailboxTrackingCategory = 9609, 
		
			[Label("Mailbox Statistics")]
			[Description(@"Stores data regarding Mailbox processing cycles")]
			MailboxStatistics = 9607, 
		
			[Label("Mail Merge Template")]
			[Description(@"Template for a mail merge document that contains the standard attributes of that document.")]
			MailMergeTemplate = 9106, 
		
			[Label("Mailbox Auto Tracking Folder")]
			[Description(@"Stores data about what folders for a mailbox are auto tracked")]
			MailboxAutoTrackingFolder = 9608, 
		
			[Label("LocalConfigStore")]
			[Description(@"")]
			LocalConfigStore = 9201, 
		
			[Label("List Operation")]
			[Description(@"System operation used to perform lengthy and asynchronous list operations on large data sets, such as adding members to a list.")]
			ListOperation = 10066, 
		
			[Label("Mailbox")]
			[Description(@"")]
			Mailbox = 9606, 
		
			[Label("Lookup Mapping")]
			[Description(@"In a data map, maps a lookup attribute in a source file to Microsoft Dynamics 365.")]
			LookupMapping = 4419, 
		
			[Label("Article Comment")]
			[Description(@"Comment on a knowledge base article.")]
			ArticleComment = 1082, 
		
			[Label("Article")]
			[Description(@"Structured content that is part of the knowledge base.")]
			Article = 127, 
		
			[Label("Knowledge Article")]
			[Description(@"Organizational knowledge for internal and external use.")]
			KnowledgeArticle = 9953, 
		
			[Label("Article Template")]
			[Description(@"Template for a knowledge base article that contains the standard attributes of an article.")]
			ArticleTemplate = 1016, 
		
			[Label("Invoice")]
			[Description(@"Order that has been billed.")]
			Invoice = 1090, 
		
			[Label("Invalid Dependency")]
			[Description(@"An invalid dependency in the CRM system.")]
			InvalidDependency = 7107, 
		
			[Label("ISV Config")]
			[Description(@"An XML document used to configure client extension controls.")]
			ISVConfig = 4705, 
		
			[Label("Invoice Product")]
			[Description(@"Line item in an invoice containing detailed billing information for a product.")]
			InvoiceProduct = 1091, 
		
			[Label("Language")]
			[Description(@"Language")]
			Language = 9957, 
		
			[Label("Knowledge Search Model")]
			[Description(@"Configuration for automatic suggestion of knowledge articles using text analytics and search")]
			KnowledgeSearchModel = 9947, 
		
			[Label("Lead")]
			[Description(@"Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.")]
			Lead = 4, 
		
			[Label("Language Provisioning State")]
			[Description(@"Container for language provisioning checkpoint states")]
			LanguageProvisioningState = 9875, 
		
			[Label("Knowledge Article Category")]
			[Description(@"Category for a Knowledge Article.")]
			KnowledgeArticleCategory = 9960, 
		
			[Label("Knowledge Article Incident")]
			[Description(@"Association between an knowledge article and incident.")]
			KnowledgeArticleIncident = 9954, 
		
			[Label("Knowledge Base Record")]
			[Description(@"Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.")]
			KnowledgeBaseRecord = 9930, 
		
			[Label("Knowledge Article Views")]
			[Description(@"No of times an article is viewed per day")]
			KnowledgeArticleViews = 9955, 
		
			[Label("Managed Property")]
			[Description(@"")]
			ManagedProperty = 9812, 
		
			[Label("AI Object Detection Image Mapping")]
			[Description(@"")]
			AIObjectDetectionImageMapping = 10064, 
		
			[Label("AI Object Detection Bounding Box")]
			[Description(@"")]
			AIObjectDetectionBoundingBox = 10063, 
		
			[Label("Auto Capture Rule")]
			[Description(@"")]
			AutoCaptureRule = 10092, 
		
			[Label("AI Template")]
			[Description(@"")]
			AITemplate = 400, 
		
			[Label("AI Model")]
			[Description(@"")]
			AIModel = 401, 
		
			[Label("AI Form Processing Document")]
			[Description(@"")]
			AIFormProcessingDocument = 10060, 
		
			[Label("AI Object Detection Label")]
			[Description(@"")]
			AIObjectDetectionLabel = 10062, 
		
			[Label("AI Object Detection Image")]
			[Description(@"")]
			AIObjectDetectionImage = 10061, 
		
			[Label("Database Version")]
			[Description(@"Stores the latest database version for a solution, for internal use only.")]
			DatabaseVersion = 10067, 
		
			[Label("Component Layer Data Source")]
			[Description(@"")]
			ComponentLayerDataSource = 10006, 
		
			[Label("Knowledge Federated Article")]
			[Description(@"")]
			KnowledgeFederatedArticle = 10041, 
		
			[Label("EntityRankingRule")]
			[Description(@"")]
			EntityRankingRule = 10089, 
		
			[Label("Playbook Callable Context")]
			[Description(@"")]
			PlaybookCallableContext = 10076, 
		
			[Label("Auto Capture Settings")]
			[Description(@"")]
			AutoCaptureSettings = 10093, 
		
			[Label("Component Layer")]
			[Description(@"")]
			ComponentLayer = 10005, 
		
			[Label("Microsoft Teams Graph resource Entity")]
			[Description(@"Entity which stores collaboration data of Dynamics 365 with Microsoft Teams")]
			MicrosoftTeamsGraphResourceEntity = 10106, 
		
			[Label("Mobile Offline Profile Item Association")]
			[Description(@"Information on relationships to be used to follow related entity's records for mobile offline profile item.")]
			MobileOfflineProfileItemAssociation = 9868, 
		
			[Label("Mobile Offline Profile Item")]
			[Description(@"Information on entity availability to mobile devices in offline mode for a mobile offline profile item.")]
			MobileOfflineProfileItem = 9867, 
		
			[Label("Action Card Regarding")]
			[Description(@"")]
			ActionCardRegarding = 10087, 
		
			[Label("Monthly Fiscal Calendar")]
			[Description(@"Monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.")]
			MonthlyFiscalCalendar = 2003, 
		
			[Label("Metadata Difference")]
			[Description(@"Metadata Difference")]
			MetadataDifference = 4231, 
		
			[Label("Marketing Form Display Attributes")]
			[Description(@"Setting to allow customized form for In-app Marketing Form")]
			MarketingFormDisplayAttributes = 10142, 
		
			[Label("Mobile Offline Profile")]
			[Description(@"Information to administer and manage the data available to mobile devices in offline mode.")]
			MobileOfflineProfile = 9866, 
		
			[Label("Goal Metric")]
			[Description(@"Type of measurement for a goal, such as money amount or count.")]
			GoalMetric = 9603, 
		
			[Label("AI Builder File")]
			[Description(@"")]
			AIBuilderFile = 10058, 
		
			[Label("AI Builder Datasets Container")]
			[Description(@"")]
			AIBuilderDatasetsContainer = 10057, 
		
			[Label("AI Configuration")]
			[Description(@"")]
			AIConfiguration = 402, 
		
			[Label("AI Builder File Attached Data")]
			[Description(@"")]
			AIBuilderFileAttachedData = 10059, 
		
			[Label("AI Builder Dataset")]
			[Description(@"")]
			AIBuilderDataset = 10054, 
		
			[Label("Action Card Role Setting")]
			[Description(@"")]
			ActionCardRoleSetting = 10088, 
		
			[Label("AI Builder Dataset Record")]
			[Description(@"")]
			AIBuilderDatasetRecord = 10056, 
		
			[Label("AI Builder Dataset File")]
			[Description(@"")]
			AIBuilderDatasetFile = 10055, 
		
			[Label("Inter Process Lock")]
			[Description(@"Inter Process Locks.")]
			InterProcessLock = 4011, 
		
			[Label("Virtual Entity Data Provider")]
			[Description(@"Developers can register plug-ins on a data provider to enable data access for virtual entities in the system.")]
			VirtualEntityDataProvider = 78, 
		
			[Label("Entity Analytics Config")]
			[Description(@"This entity contains information about which entities are enabled for Azure Data Lake Services integration")]
			EntityAnalyticsConfig = 430, 
		
			[Label("Entity Image Configuration")]
			[Description(@"Store image configuration for each entity")]
			EntityImageConfiguration = 432, 
		
			[Label("Virtual Entity Data Source")]
			[Description(@"Internal entity that stores data source information for all installed providers.")]
			VirtualEntityDataSource = 85, 
		
			[Label("Entitlement Template Channel")]
			[Description(@"Contains predefined support terms for a channel to create entitlements for customers.")]
			EntitlementTemplateChannel = 9703, 
		
			[Label("Entitlement Template")]
			[Description(@"Contains predefined customer support terms that can be used to created entitlements for customers.")]
			EntitlementTemplate = 9702, 
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 9800, 
		
			[Label("Entitlement Template Product")]
			[Description(@"")]
			EntitlementTemplateProduct = 4545, 
		
			[Label("Facility/Equipment")]
			[Description(@"Resource that can be scheduled.")]
			FacilityEquipment = 4000, 
		
			[Label("Environment Variable Value")]
			[Description(@"Holds the value for the associated EnvironmentVariableDefinition entity.")]
			EnvironmentVariableValue = 381, 
		
			[Label("Expander Event")]
			[Description(@"For internal use only. An event that will be expanded into jobs whose executions can proceed in the background.")]
			ExpanderEvent = 4711, 
		
			[Label("Exchange Sync Id Mapping")]
			[Description(@"The mapping used to keep track of the IDs for items synced between CRM and Exchange.")]
			ExchangeSyncIdMapping = 4120, 
		
			[Label("Entity Map")]
			[Description(@"Represents a mapping between two related entities so that data from one record can be copied into the form of a new related record.")]
			EntityMap = 4600, 
		
			[Label("Entity Key")]
			[Description(@"")]
			EntityKey = 9810, 
		
			[Label("Environment Variable Definition")]
			[Description(@"Contains information about the settable variable: its type, default value, and etc.")]
			EnvironmentVariableDefinition = 380, 
		
			[Label("Entity Relationship")]
			[Description(@"")]
			EntityRelationship = 9811, 
		
			[Label("Property Option Set Item")]
			[Description(@"Item with a name and value in a property option set type.")]
			PropertyOptionSetItem = 1049, 
		
			[Label("Property Instance")]
			[Description(@"Instance of a property with its value.")]
			PropertyInstance = 1333, 
		
			[Label("Email Hash")]
			[Description(@"Email activity hashes used for correlation purposes.")]
			EmailHash = 4023, 
		
			[Label("Email")]
			[Description(@"Activity that is delivered using email protocols.")]
			Email = 4202, 
		
			[Label("Duplicate Rule Condition")]
			[Description(@"Condition of a duplicate detection rule.")]
			DuplicateRuleCondition = 4416, 
		
			[Label("Duplicate Detection Rule")]
			[Description(@"Rule used to identify potential duplicates.")]
			DuplicateDetectionRule = 4414, 
		
			[Label("Property Association")]
			[Description(@"Association of a property definition with another entity in the system.")]
			PropertyAssociation = 1235, 
		
			[Label("Property")]
			[Description(@"Information about a product property.")]
			Property = 1048, 
		
			[Label("Entitlement Contact")]
			[Description(@"")]
			EntitlementContact = 7272, 
		
			[Label("Entitlement Channel")]
			[Description(@"Defines the amount and type of support for a channel.")]
			EntitlementChannel = 9701, 
		
			[Label("Entitlement Product")]
			[Description(@"")]
			EntitlementProduct = 6363, 
		
			[Label("Entitlement Entity Allocation Type Mapping")]
			[Description(@"Mapping to define which Allocation Types are available for Entity Type to be used on Entitlement")]
			EntitlementEntityAllocationTypeMapping = 9704, 
		
			[Label("Email Server Profile")]
			[Description(@"Holds the Email Server Profiles of an organization")]
			EmailServerProfile = 9605, 
		
			[Label("Email Search")]
			[Description(@"Email Address Search Table.")]
			EmailSearch = 4299, 
		
			[Label("Entitlement")]
			[Description(@"Defines the amount and type of support a customer should receive.")]
			Entitlement = 9700, 
		
			[Label("Email Signature")]
			[Description(@"Signature for email message")]
			EmailSignature = 9997, 
		
			[Label("Expired Process")]
			[Description(@"Expired Process Business Process Flow")]
			ExpiredProcess = 955, 
		
			[Label("Import Source File")]
			[Description(@"File name of file used for import.")]
			ImportSourceFile = 4412, 
		
			[Label("Import Entity Mapping")]
			[Description(@"Mapping for entities in a data map.")]
			ImportEntityMapping = 4428, 
		
			[Label("Import Log")]
			[Description(@"Failure reason and other detailed information for a record that failed to import.")]
			ImportLog = 4423, 
		
			[Label("Import Job")]
			[Description(@"For internal use only.")]
			ImportJob = 9107, 
		
			[Label("Image Descriptor")]
			[Description(@"For internal use only.")]
			ImageDescriptor = 1007, 
		
			[Label("HolidayWrapper")]
			[Description(@"")]
			HolidayWrapper = 9996, 
		
			[Label("Import Data")]
			[Description(@"Unprocessed data from imported files.")]
			ImportData = 4413, 
		
			[Label("Data Import")]
			[Description(@"Status and ownership information for an import job.")]
			DataImport = 4410, 
		
			[Label("Interaction for Email")]
			[Description(@"")]
			InteractionForEmail = 9986, 
		
			[Label("Integration Status")]
			[Description(@"Contains integration status information.")]
			IntegrationStatus = 3000, 
		
			[Label("Internal Catalog Assignment")]
			[Description(@"")]
			InternalCatalogAssignment = 10050, 
		
			[Label("Internal Address")]
			[Description(@"Storage of addresses for a user, business unit, or site.")]
			InternalAddress = 1003, 
		
			[Label("Case")]
			[Description(@"Service request case associated with a contract.")]
			Case = 112, 
		
			[Label("Data Map")]
			[Description(@"Data map used in import.")]
			DataMap = 4411, 
		
			[Label("Case Resolution")]
			[Description(@"Special type of activity that includes description of the resolution, billing status, and the duration of the case.")]
			CaseResolution = 4206, 
		
			[Label("Incident KnowledgeBaseRecord")]
			[Description(@"")]
			IncidentKnowledgeBaseRecord = 9931, 
		
			[Label("Field Permission")]
			[Description(@"Group of privileges used to categorize users to provide appropriate access to secured columns.")]
			FieldPermission = 1201, 
		
			[Label("Feedback")]
			[Description(@"Container for feedback and ratings for knowledge articles.")]
			Feedback = 9958, 
		
			[Label("FileAttachment")]
			[Description(@"File Attachment")]
			FileAttachment = 55, 
		
			[Label("Field Security Profile")]
			[Description(@"Profile which defines access level for secured attributes")]
			FieldSecurityProfile = 1200, 
		
			[Label("External Party")]
			[Description(@"Information about external parties that need to access Dynamics 365 from external channels.For internal use only")]
			ExternalParty = 3008, 
		
			[Label("ExportSolutionUpload")]
			[Description(@"")]
			ExportSolutionUpload = 10010, 
		
			[Label("Fax")]
			[Description(@"Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.")]
			Fax = 4204, 
		
			[Label("External Party Item")]
			[Description(@"Information about external party items that need to access Dynamics 365 from external channels.For internal use only")]
			ExternalPartyItem = 9987, 
		
			[Label("Rollup Query")]
			[Description(@"Query that is used to filter the results of the goal rollup.")]
			RollupQuery = 9602, 
		
			[Label("Goal")]
			[Description(@"Target objective for a user or a team for a specified time period.")]
			Goal = 9600, 
		
			[Label("Hierarchy Security Configuration")]
			[Description(@"")]
			HierarchySecurityConfiguration = 9919, 
		
			[Label("Hierarchy Rule")]
			[Description(@"Organization-owned entity customizations including mapping Quick view form with Relationship Id")]
			HierarchyRule = 8840, 
		
			[Label("Fixed Monthly Fiscal Calendar")]
			[Description(@"Fixed monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.")]
			FixedMonthlyFiscalCalendar = 2004, 
		
			[Label("Filter Template")]
			[Description(@"Template for a filter.")]
			FilterTemplate = 30, 
		
			[Label("Global Search Configuration")]
			[Description(@"")]
			GlobalSearchConfiguration = 54, 
		
			[Label("Flow Session")]
			[Description(@"Entity to store the information that is generated when a modern flow or UI flow runs.")]
			FlowSession = 4720, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>entitiesperfile</summary>
			public const string EntitiesPerFile = "entitiesperfile";

			/// <summary>importmapid</summary>
			public const string DataMapId = "importmapid";

			/// <summary>importmapidunique</summary>
			public const string ImportmapiduniqueId = "importmapidunique";

			/// <summary>importmaptype</summary>
			public const string MapType = "importmaptype";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>isvalidforimport</summary>
			public const string IsValidForImport = "isvalidforimport";

			/// <summary>iswizardcreated</summary>
			public const string IsWizardCreated = "iswizardcreated";

			/// <summary>mapcustomizations</summary>
			public const string MapCustomizations = "mapcustomizations";

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
			public const string MapName = "name";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

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

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>source</summary>
			public const string Source = "source";

			/// <summary>sourcetype</summary>
			public const string SourceSystemType = "sourcetype";

			/// <summary>sourceuseridentifierforsourcecrmuserlink</summary>
			public const string SourceUserValue = "sourceuseridentifierforsourcecrmuserlink";

			/// <summary>sourceuseridentifierforsourcedatasourceuserlink</summary>
			public const string SourceUserIdentifier = "sourceuseridentifierforsourcedatasourceuserlink";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>targetentity</summary>
			public const string RecordType = "targetentity";

			/// <summary>targetuseridentifierforsourcecrmuserlink</summary>
			public const string TargetUserValue = "targetuseridentifierforsourcecrmuserlink";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ColumnMapping_ImportMap</summary>
			public const string ColumnMappingImportMap = "ColumnMapping_ImportMap";

			/// <summary>1:N ImportEntityMapping_ImportMap</summary>
			public const string ImportEntityMappingImportMap = "ImportEntityMapping_ImportMap";

			/// <summary>1:N ImportMap_AsyncOperations</summary>
			public const string ImportMapAsyncOperations = "ImportMap_AsyncOperations";

			/// <summary>1:N ImportMap_BulkDeleteFailures</summary>
			public const string ImportMapBulkDeleteFailures = "ImportMap_BulkDeleteFailures";

			/// <summary>1:N ImportMap_ImportFile</summary>
			public const string ImportMapImportFile = "ImportMap_ImportFile";

			/// <summary>1:N ImportMap_SyncErrors</summary>
			public const string ImportMapSyncErrors = "ImportMap_SyncErrors";

			/// <summary>1:N OwnerMapping_ImportMap</summary>
			public const string OwnerMappingImportMap = "OwnerMapping_ImportMap";

			/// <summary>1:N TransformationMapping_ImportMap</summary>
			public const string TransformationMappingImportMap = "TransformationMapping_ImportMap";

		}
		#endregion
	}
}

