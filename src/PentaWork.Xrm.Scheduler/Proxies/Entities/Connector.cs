using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{LogicalNameOfTheConnector}")] 	
	[EntityLogicalName("connector")]
	public sealed class Connector : Entity
	{	
		public static readonly int? EntityTypeCode = 372;
		public new const string LogicalName = "connector";
		public const string PrimaryIdAttribute = "connectorid";
		public const string PrimaryNameAttribute = "name";
	
		public Connector() : base("connector") { }

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
        /// connectionparameters
        /// </summary>
		[DisplayName("ConnectionParameters")]
		[AttributeLogicalName("connectionparameters")]
		public string ConnectionParameters
		{	
			get { return GetAttributeValue<string>("connectionparameters"); }
			set
			{ 
				if(value == ConnectionParameters) return;
				SetAttributeValue("connectionparameters", value);
			}
		}	
			
		/// <summary>
        /// connectorid
        /// </summary>
		[DisplayName("Connector")]
		[AttributeLogicalName("connectorid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("connectorid", value); }
		}

							/// <summary>
        /// connectoridunique
        /// </summary>
		[DisplayName("connectoridunique")]
		[AttributeLogicalName("connectoridunique")]
		public Guid ConnectoriduniqueId
		{	
			get { return GetAttributeValue<Guid>("connectoridunique"); }
			set
			{ 
				if(value == ConnectoriduniqueId) return;
				SetAttributeValue("connectoridunique", value);
			}
		}	
			
		/// <summary>
        /// connectorinternalid
        /// </summary>
		[DisplayName("Internal Connector Id")]
		[AttributeLogicalName("connectorinternalid")]
		public string InternalConnectorId
		{	
			get { return GetAttributeValue<string>("connectorinternalid"); }
			set
			{ 
				if(value == InternalConnectorId) return;
				SetAttributeValue("connectorinternalid", value);
			}
		}	
			
		/// <summary>
        /// connectortype
        /// </summary>
		[DisplayName("Connector Type")]
		[AttributeLogicalName("connectortype")]
		public egConnectorType? ConnectorType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("connectortype");
				if (optionSetValue != null) return (egConnectorType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ConnectorType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("connectortype", optionSetValue); 
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
        /// iconblob_timestamp
        /// </summary>
		[DisplayName("iconblob_timestamp")]
		[AttributeLogicalName("iconblob_timestamp")]
		public int? IconblobTimestamp
		{	
			get { return GetAttributeValue<int?>("iconblob_timestamp"); }
			set
			{ 
				if(value == IconblobTimestamp) return;
				SetAttributeValue("iconblob_timestamp", value);
			}
		}	
			
		/// <summary>
        /// iconblob_url
        /// </summary>
		[DisplayName("iconblob_url")]
		[AttributeLogicalName("iconblob_url")]
		public string IconblobUrl
		{	
			get { return GetAttributeValue<string>("iconblob_url"); }
			set
			{ 
				if(value == IconblobUrl) return;
				SetAttributeValue("iconblob_url", value);
			}
		}	
			
		/// <summary>
        /// iconblobid
        /// </summary>
		[DisplayName("iconblobid")]
		[AttributeLogicalName("iconblobid")]
		public Guid IconblobId
		{	
			get { return GetAttributeValue<Guid>("iconblobid"); }
			set
			{ 
				if(value == IconblobId) return;
				SetAttributeValue("iconblobid", value);
			}
		}	
			
		/// <summary>
        /// iconbrandcolor
        /// </summary>
		[DisplayName("Icon Brand Color")]
		[AttributeLogicalName("iconbrandcolor")]
		public string IconBrandColor
		{	
			get { return GetAttributeValue<string>("iconbrandcolor"); }
			set
			{ 
				if(value == IconBrandColor) return;
				SetAttributeValue("iconbrandcolor", value);
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
		[DisplayName("Logical Name of the Connector")]
		[AttributeLogicalName("name")]
		public string LogicalNameOfTheConnector
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == LogicalNameOfTheConnector) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// openapidefinition
        /// </summary>
		[DisplayName("Open Api Definition")]
		[AttributeLogicalName("openapidefinition")]
		public string OpenApiDefinition
		{	
			get { return GetAttributeValue<string>("openapidefinition"); }
			set
			{ 
				if(value == OpenApiDefinition) return;
				SetAttributeValue("openapidefinition", value);
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
        /// policytemplateinstances
        /// </summary>
		[DisplayName("PolicyTemplateInstances")]
		[AttributeLogicalName("policytemplateinstances")]
		public string PolicyTemplateInstances
		{	
			get { return GetAttributeValue<string>("policytemplateinstances"); }
			set
			{ 
				if(value == PolicyTemplateInstances) return;
				SetAttributeValue("policytemplateinstances", value);
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
        /// 1:N Get entities for 'connector_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("connector_AsyncOperations")]
		public IEnumerable<SystemJob> ConnectorAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("connector_AsyncOperations", null); }
			set { SetRelatedEntities("connector_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("connector_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ConnectorBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("connector_BulkDeleteFailures", null); }
			set { SetRelatedEntities("connector_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_connectionreference'
        /// </summary>
		[RelationshipSchemaName("connector_connectionreference")]
		public IEnumerable<ConnectionReference> ConnectorConnectionreference
		{
			get { return GetRelatedEntities<ConnectionReference>("connector_connectionreference", null); }
			set { SetRelatedEntities("connector_connectionreference", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("connector_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ConnectorDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("connector_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("connector_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("connector_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ConnectorDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("connector_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("connector_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("connector_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ConnectorMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("connector_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("connector_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("connector_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ConnectorPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("connector_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("connector_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("connector_ProcessSession")]
		public IEnumerable<ProcessSession> ConnectorProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("connector_ProcessSession", null); }
			set { SetRelatedEntities("connector_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connector_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("connector_SyncErrors")]
		public IEnumerable<SyncError> ConnectorSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("connector_SyncErrors", null); }
			set { SetRelatedEntities("connector_SyncErrors", null, value); }
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
		
		public enum egConnectorType
		{	
		
			[Label("CustomConnector")]
			[Description(@"")]
			CustomConnector = 1, 
		
			[Label("NotSpecified")]
			[Description(@"")]
			NotSpecified = 0, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>connectionparameters</summary>
			public const string ConnectionParameters = "connectionparameters";

			/// <summary>connectorid</summary>
			public const string ConnectorId = "connectorid";

			/// <summary>connectoridunique</summary>
			public const string ConnectoriduniqueId = "connectoridunique";

			/// <summary>connectorinternalid</summary>
			public const string InternalConnectorId = "connectorinternalid";

			/// <summary>connectortype</summary>
			public const string ConnectorType = "connectortype";

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

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>iconblob_timestamp</summary>
			public const string IconblobTimestamp = "iconblob_timestamp";

			/// <summary>iconblob_url</summary>
			public const string IconblobUrl = "iconblob_url";

			/// <summary>iconblobid</summary>
			public const string IconblobId = "iconblobid";

			/// <summary>iconbrandcolor</summary>
			public const string IconBrandColor = "iconbrandcolor";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

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
			public const string LogicalNameOfTheConnector = "name";

			/// <summary>openapidefinition</summary>
			public const string OpenApiDefinition = "openapidefinition";

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

			/// <summary>policytemplateinstances</summary>
			public const string PolicyTemplateInstances = "policytemplateinstances";

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
			/// <summary>1:N connector_AsyncOperations</summary>
			public const string ConnectorAsyncOperations = "connector_AsyncOperations";

			/// <summary>1:N connector_BulkDeleteFailures</summary>
			public const string ConnectorBulkDeleteFailures = "connector_BulkDeleteFailures";

			/// <summary>1:N connector_connectionreference</summary>
			public const string ConnectorConnectionreference = "connector_connectionreference";

			/// <summary>1:N connector_DuplicateBaseRecord</summary>
			public const string ConnectorDuplicateBaseRecord = "connector_DuplicateBaseRecord";

			/// <summary>1:N connector_DuplicateMatchingRecord</summary>
			public const string ConnectorDuplicateMatchingRecord = "connector_DuplicateMatchingRecord";

			/// <summary>1:N connector_MailboxTrackingFolders</summary>
			public const string ConnectorMailboxTrackingFolders = "connector_MailboxTrackingFolders";

			/// <summary>1:N connector_PrincipalObjectAttributeAccesses</summary>
			public const string ConnectorPrincipalObjectAttributeAccesses = "connector_PrincipalObjectAttributeAccesses";

			/// <summary>1:N connector_ProcessSession</summary>
			public const string ConnectorProcessSession = "connector_ProcessSession";

			/// <summary>1:N connector_SyncErrors</summary>
			public const string ConnectorSyncErrors = "connector_SyncErrors";

		}
		#endregion
	}
}

