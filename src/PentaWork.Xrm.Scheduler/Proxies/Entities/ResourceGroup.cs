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
	[EntityLogicalName("constraintbasedgroup")]
	public sealed class ResourceGroup : Entity
	{	
		public static readonly int? EntityTypeCode = 4007;
		public new const string LogicalName = "constraintbasedgroup";
		public const string PrimaryIdAttribute = "constraintbasedgroupid";
		public const string PrimaryNameAttribute = "name";
	
		public ResourceGroup() : base("constraintbasedgroup") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
			}
		}	
			
		/// <summary>
        /// constraintbasedgroupid
        /// </summary>
		[DisplayName("Resource Group")]
		[AttributeLogicalName("constraintbasedgroupid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("constraintbasedgroupid", value); }
		}

							/// <summary>
        /// constraints
        /// </summary>
		[DisplayName("Constraints")]
		[AttributeLogicalName("constraints")]
		public string Constraints
		{	
			get { return GetAttributeValue<string>("constraints"); }
			set
			{ 
				if(value == Constraints) return;
				SetAttributeValue("constraints", value);
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
        /// grouptypecode
        /// </summary>
		[DisplayName("Group Type")]
		[AttributeLogicalName("grouptypecode")]
		public eGroupType? GroupType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("grouptypecode");
				if (optionSetValue != null) return (eGroupType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == GroupType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("grouptypecode", optionSetValue); 
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
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
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
        /// 1:N Get entities for 'constraint_based_group_resource_specs'
        /// </summary>
		[RelationshipSchemaName("constraint_based_group_resource_specs")]
		public IEnumerable<ResourceSpecification> ConstraintBasedGroupResourceSpecs
		{
			get { return GetRelatedEntities<ResourceSpecification>("constraint_based_group_resource_specs", null); }
			set { SetRelatedEntities("constraint_based_group_resource_specs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ConstraintBasedGroup_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ConstraintBasedGroup_AsyncOperations")]
		public IEnumerable<SystemJob> ConstraintBasedGroupAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ConstraintBasedGroup_AsyncOperations", null); }
			set { SetRelatedEntities("ConstraintBasedGroup_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ConstraintBasedGroup_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ConstraintBasedGroup_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ConstraintBasedGroupBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ConstraintBasedGroup_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ConstraintBasedGroup_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_connections1'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_connections1")]
		public IEnumerable<Connection> ConstraintbasedgroupConnections1
		{
			get { return GetRelatedEntities<Connection>("constraintbasedgroup_connections1", null); }
			set { SetRelatedEntities("constraintbasedgroup_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_connections2'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_connections2")]
		public IEnumerable<Connection> ConstraintbasedgroupConnections2
		{
			get { return GetRelatedEntities<Connection>("constraintbasedgroup_connections2", null); }
			set { SetRelatedEntities("constraintbasedgroup_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ConstraintbasedgroupMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("constraintbasedgroup_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("constraintbasedgroup_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ConstraintbasedgroupPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("constraintbasedgroup_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("constraintbasedgroup_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ConstraintBasedGroup_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("ConstraintBasedGroup_ProcessSessions")]
		public IEnumerable<ProcessSession> ConstraintBasedGroupProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("ConstraintBasedGroup_ProcessSessions", null); }
			set { SetRelatedEntities("ConstraintBasedGroup_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_resource_groups'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_resource_groups")]
		public IEnumerable<SchedulingGroup> ConstraintbasedgroupResourceGroups
		{
			get { return GetRelatedEntities<SchedulingGroup>("constraintbasedgroup_resource_groups", null); }
			set { SetRelatedEntities("constraintbasedgroup_resource_groups", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_SyncErrors")]
		public IEnumerable<SyncError> ConstraintbasedgroupSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("constraintbasedgroup_SyncErrors", null); }
			set { SetRelatedEntities("constraintbasedgroup_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_virtualresourceg'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_virtualresourceg")]
		public IEnumerable<VirtualResourceGroupResource> ConstraintbasedgroupVirtualresourceg
		{
			get { return GetRelatedEntities<VirtualResourceGroupResource>("constraintbasedgroup_virtualresourceg", null); }
			set { SetRelatedEntities("constraintbasedgroup_virtualresourceg", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eGroupType
		{	
		
			[Label("Static")]
			[Description(@"")]
			Static = 0, 
		
			[Label("Dynamic")]
			[Description(@"")]
			Dynamic = 1, 
		
			[Label("Hidden")]
			[Description(@"")]
			Hidden = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>constraintbasedgroupid</summary>
			public const string ResourceGroupId = "constraintbasedgroupid";

			/// <summary>constraints</summary>
			public const string Constraints = "constraints";

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

			/// <summary>grouptypecode</summary>
			public const string GroupType = "grouptypecode";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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
			/// <summary>1:N constraint_based_group_resource_specs</summary>
			public const string ConstraintBasedGroupResourceSpecs = "constraint_based_group_resource_specs";

			/// <summary>1:N ConstraintBasedGroup_AsyncOperations</summary>
			public const string ConstraintBasedGroupAsyncOperations = "ConstraintBasedGroup_AsyncOperations";

			/// <summary>1:N ConstraintBasedGroup_BulkDeleteFailures</summary>
			public const string ConstraintBasedGroupBulkDeleteFailures = "ConstraintBasedGroup_BulkDeleteFailures";

			/// <summary>1:N constraintbasedgroup_connections1</summary>
			public const string ConstraintbasedgroupConnections1 = "constraintbasedgroup_connections1";

			/// <summary>1:N constraintbasedgroup_connections2</summary>
			public const string ConstraintbasedgroupConnections2 = "constraintbasedgroup_connections2";

			/// <summary>1:N constraintbasedgroup_MailboxTrackingFolders</summary>
			public const string ConstraintbasedgroupMailboxTrackingFolders = "constraintbasedgroup_MailboxTrackingFolders";

			/// <summary>1:N constraintbasedgroup_PrincipalObjectAttributeAccesses</summary>
			public const string ConstraintbasedgroupPrincipalObjectAttributeAccesses = "constraintbasedgroup_PrincipalObjectAttributeAccesses";

			/// <summary>1:N ConstraintBasedGroup_ProcessSessions</summary>
			public const string ConstraintBasedGroupProcessSessions = "ConstraintBasedGroup_ProcessSessions";

			/// <summary>1:N constraintbasedgroup_resource_groups</summary>
			public const string ConstraintbasedgroupResourceGroups = "constraintbasedgroup_resource_groups";

			/// <summary>1:N constraintbasedgroup_SyncErrors</summary>
			public const string ConstraintbasedgroupSyncErrors = "constraintbasedgroup_SyncErrors";

			/// <summary>1:N constraintbasedgroup_virtualresourceg</summary>
			public const string ConstraintbasedgroupVirtualresourceg = "constraintbasedgroup_virtualresourceg";

		}
		#endregion
	}
}

