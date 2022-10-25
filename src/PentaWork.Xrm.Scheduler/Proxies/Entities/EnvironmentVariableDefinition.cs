using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{SchemaName}")] 	
	[EntityLogicalName("environmentvariabledefinition")]
	public sealed class EnvironmentVariableDefinition : Entity
	{	
		public static readonly int? EntityTypeCode = 380;
		public new const string LogicalName = "environmentvariabledefinition";
		public const string PrimaryIdAttribute = "environmentvariabledefinitionid";
		public const string PrimaryNameAttribute = "schemaname";
	
		public EnvironmentVariableDefinition() : base("environmentvariabledefinition") { }

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
        /// connectionreferenceid
        /// </summary>
		[DisplayName("Connection Reference")]
		[AttributeLogicalName("connectionreferenceid")]
		public EntityReference ConnectionReference
		{	
			get { return GetAttributeValue<EntityReference>("connectionreferenceid"); }
			set
			{ 
				if(value == ConnectionReference) return;
				SetAttributeValue("connectionreferenceid", value);
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
        /// datasourcetype
        /// </summary>
		[DisplayName("Data Source Type")]
		[AttributeLogicalName("datasourcetype")]
		public string DataSourceType
		{	
			get { return GetAttributeValue<string>("datasourcetype"); }
			set
			{ 
				if(value == DataSourceType) return;
				SetAttributeValue("datasourcetype", value);
			}
		}	
			
		/// <summary>
        /// defaultvalue
        /// </summary>
		[DisplayName("Default Value")]
		[AttributeLogicalName("defaultvalue")]
		public string DefaultValue
		{	
			get { return GetAttributeValue<string>("defaultvalue"); }
			set
			{ 
				if(value == DefaultValue) return;
				SetAttributeValue("defaultvalue", value);
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
        /// displayname
        /// </summary>
		[DisplayName("Display Name")]
		[AttributeLogicalName("displayname")]
		public string DisplayName
		{	
			get { return GetAttributeValue<string>("displayname"); }
			set
			{ 
				if(value == DisplayName) return;
				SetAttributeValue("displayname", value);
			}
		}	
			
		/// <summary>
        /// environmentvariabledefinitionid
        /// </summary>
		[DisplayName("Environment Variable Definition")]
		[AttributeLogicalName("environmentvariabledefinitionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("environmentvariabledefinitionid", value); }
		}

							/// <summary>
        /// environmentvariabledefinitionidunique
        /// </summary>
		[DisplayName("environmentvariabledefinitionidunique")]
		[AttributeLogicalName("environmentvariabledefinitionidunique")]
		public Guid EnvironmentvariabledefinitioniduniqueId
		{	
			get { return GetAttributeValue<Guid>("environmentvariabledefinitionidunique"); }
			set
			{ 
				if(value == EnvironmentvariabledefinitioniduniqueId) return;
				SetAttributeValue("environmentvariabledefinitionidunique", value);
			}
		}	
			
		/// <summary>
        /// hint
        /// </summary>
		[DisplayName("Hint")]
		[AttributeLogicalName("hint")]
		public string Hint
		{	
			get { return GetAttributeValue<string>("hint"); }
			set
			{ 
				if(value == Hint) return;
				SetAttributeValue("hint", value);
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
        /// isrequired
        /// </summary>
		[DisplayName("Is Required")]
		[AttributeLogicalName("isrequired")]
		public bool? IsRequired
		{	
			get { return GetAttributeValue<bool?>("isrequired"); }
			set
			{ 
				if(value == IsRequired) return;
				SetAttributeValue("isrequired", value);
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
        /// parentdefinitionid
        /// </summary>
		[DisplayName("Parent Definition")]
		[AttributeLogicalName("parentdefinitionid")]
		public EntityReference ParentDefinition
		{	
			get { return GetAttributeValue<EntityReference>("parentdefinitionid"); }
			set
			{ 
				if(value == ParentDefinition) return;
				SetAttributeValue("parentdefinitionid", value);
			}
		}	
			
		/// <summary>
        /// schemaname
        /// </summary>
		[DisplayName("Schema Name")]
		[AttributeLogicalName("schemaname")]
		public string SchemaName
		{	
			get { return GetAttributeValue<string>("schemaname"); }
			set
			{ 
				if(value == SchemaName) return;
				SetAttributeValue("schemaname", value);
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
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
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
        /// valueschema
        /// </summary>
		[DisplayName("Value Schema")]
		[AttributeLogicalName("valueschema")]
		public string ValueSchema
		{	
			get { return GetAttributeValue<string>("valueschema"); }
			set
			{ 
				if(value == ValueSchema) return;
				SetAttributeValue("valueschema", value);
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
        /// 1:N Get entities for 'environmentvariabledefinition_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_AsyncOperations")]
		public IEnumerable<SystemJob> EnvironmentvariabledefinitionAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("environmentvariabledefinition_AsyncOperations", null); }
			set { SetRelatedEntities("environmentvariabledefinition_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EnvironmentvariabledefinitionBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("environmentvariabledefinition_BulkDeleteFailures", null); }
			set { SetRelatedEntities("environmentvariabledefinition_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EnvironmentvariabledefinitionDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("environmentvariabledefinition_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("environmentvariabledefinition_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EnvironmentvariabledefinitionDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("environmentvariabledefinition_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("environmentvariabledefinition_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_environmentvariablevalue'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_environmentvariablevalue")]
		public IEnumerable<EnvironmentVariableValue> EnvironmentvariabledefinitionEnvironmentvariablevalue
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("environmentvariabledefinition_environmentvariablevalue", null); }
			set { SetRelatedEntities("environmentvariabledefinition_environmentvariablevalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EnvironmentvariabledefinitionMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("environmentvariabledefinition_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("environmentvariabledefinition_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EnvironmentvariabledefinitionPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("environmentvariabledefinition_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("environmentvariabledefinition_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_ProcessSession")]
		public IEnumerable<ProcessSession> EnvironmentvariabledefinitionProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("environmentvariabledefinition_ProcessSession", null); }
			set { SetRelatedEntities("environmentvariabledefinition_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariabledefinition_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("environmentvariabledefinition_SyncErrors")]
		public IEnumerable<SyncError> EnvironmentvariabledefinitionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("environmentvariabledefinition_SyncErrors", null); }
			set { SetRelatedEntities("environmentvariabledefinition_SyncErrors", null, value); }
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
		
		public enum eType
		{	
		
			[Label("String")]
			[Description(@"")]
			String = 100000000, 
		
			[Label("Number")]
			[Description(@"")]
			Number = 100000001, 
		
			[Label("Boolean")]
			[Description(@"")]
			Boolean = 100000002, 
		
			[Label("JSON")]
			[Description(@"")]
			JSON = 100000003, 
		
			[Label("Data Source")]
			[Description(@"")]
			DataSource = 100000004, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>connectionid</summary>
			public const string ConnectionId = "connectionid";

			/// <summary>connectionreferenceid</summary>
			public const string ConnectionReference = "connectionreferenceid";

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

			/// <summary>datasourcetype</summary>
			public const string DataSourceType = "datasourcetype";

			/// <summary>defaultvalue</summary>
			public const string DefaultValue = "defaultvalue";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>environmentvariabledefinitionid</summary>
			public const string EnvironmentVariableDefinitionId = "environmentvariabledefinitionid";

			/// <summary>environmentvariabledefinitionidunique</summary>
			public const string EnvironmentvariabledefinitioniduniqueId = "environmentvariabledefinitionidunique";

			/// <summary>hint</summary>
			public const string Hint = "hint";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isrequired</summary>
			public const string IsRequired = "isrequired";

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

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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

			/// <summary>parentdefinitionid</summary>
			public const string ParentDefinition = "parentdefinitionid";

			/// <summary>schemaname</summary>
			public const string SchemaName = "schemaname";

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

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>valueschema</summary>
			public const string ValueSchema = "valueschema";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N environmentvariabledefinition_AsyncOperations</summary>
			public const string EnvironmentvariabledefinitionAsyncOperations = "environmentvariabledefinition_AsyncOperations";

			/// <summary>1:N environmentvariabledefinition_BulkDeleteFailures</summary>
			public const string EnvironmentvariabledefinitionBulkDeleteFailures = "environmentvariabledefinition_BulkDeleteFailures";

			/// <summary>1:N environmentvariabledefinition_DuplicateBaseRecord</summary>
			public const string EnvironmentvariabledefinitionDuplicateBaseRecord = "environmentvariabledefinition_DuplicateBaseRecord";

			/// <summary>1:N environmentvariabledefinition_DuplicateMatchingRecord</summary>
			public const string EnvironmentvariabledefinitionDuplicateMatchingRecord = "environmentvariabledefinition_DuplicateMatchingRecord";

			/// <summary>1:N environmentvariabledefinition_environmentvariablevalue</summary>
			public const string EnvironmentvariabledefinitionEnvironmentvariablevalue = "environmentvariabledefinition_environmentvariablevalue";

			/// <summary>1:N environmentvariabledefinition_MailboxTrackingFolders</summary>
			public const string EnvironmentvariabledefinitionMailboxTrackingFolders = "environmentvariabledefinition_MailboxTrackingFolders";

			/// <summary>1:N environmentvariabledefinition_PrincipalObjectAttributeAccesses</summary>
			public const string EnvironmentvariabledefinitionPrincipalObjectAttributeAccesses = "environmentvariabledefinition_PrincipalObjectAttributeAccesses";

			/// <summary>1:N environmentvariabledefinition_ProcessSession</summary>
			public const string EnvironmentvariabledefinitionProcessSession = "environmentvariabledefinition_ProcessSession";

			/// <summary>1:N environmentvariabledefinition_SyncErrors</summary>
			public const string EnvironmentvariabledefinitionSyncErrors = "environmentvariabledefinition_SyncErrors";

		}
		#endregion
	}
}

