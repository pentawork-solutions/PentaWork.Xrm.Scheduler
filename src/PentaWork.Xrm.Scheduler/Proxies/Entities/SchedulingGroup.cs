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
	[EntityLogicalName("resourcegroup")]
	public sealed class SchedulingGroup : Entity
	{	
		public static readonly int? EntityTypeCode = 4005;
		public new const string LogicalName = "resourcegroup";
		public const string PrimaryIdAttribute = "resourcegroupid";
		public const string PrimaryNameAttribute = "name";
	
		public SchedulingGroup() : base("resourcegroup") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit Id")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnitId
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnitId) return;
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
        /// grouptypecode
        /// </summary>
		[DisplayName("Group Type Code")]
		[AttributeLogicalName("grouptypecode")]
		public eResourcegroupGrouptypecode? GroupTypeCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("grouptypecode");
				if (optionSetValue != null) return (eResourcegroupGrouptypecode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == GroupTypeCode) return;

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
        /// objecttypecode
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("objecttypecode")]
		public string Entity
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("objecttypecode", value);
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
        /// resourcegroupid
        /// </summary>
		[DisplayName("Scheduling Group")]
		[AttributeLogicalName("resourcegroupid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("resourcegroupid", value); }
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
        /// 1:N Get entities for 'ResourceGroup_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ResourceGroup_AsyncOperations")]
		public IEnumerable<SystemJob> ResourceGroupAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ResourceGroup_AsyncOperations", null); }
			set { SetRelatedEntities("ResourceGroup_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceGroup_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ResourceGroup_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ResourceGroupBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ResourceGroup_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ResourceGroup_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcegroup_connections1'
        /// </summary>
		[RelationshipSchemaName("resourcegroup_connections1")]
		public IEnumerable<Connection> ResourcegroupConnections1
		{
			get { return GetRelatedEntities<Connection>("resourcegroup_connections1", null); }
			set { SetRelatedEntities("resourcegroup_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcegroup_connections2'
        /// </summary>
		[RelationshipSchemaName("resourcegroup_connections2")]
		public IEnumerable<Connection> ResourcegroupConnections2
		{
			get { return GetRelatedEntities<Connection>("resourcegroup_connections2", null); }
			set { SetRelatedEntities("resourcegroup_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceGroup_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("ResourceGroup_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ResourceGroupDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("ResourceGroup_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceGroup_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("ResourceGroup_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ResourceGroupDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("ResourceGroup_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcegroup_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("resourcegroup_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ResourcegroupMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("resourcegroup_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("resourcegroup_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcegroup_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("resourcegroup_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ResourcegroupPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("resourcegroup_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("resourcegroup_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceGroup_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ResourceGroup_SyncErrors")]
		public IEnumerable<SyncError> ResourceGroupSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ResourceGroup_SyncErrors", null); }
			set { SetRelatedEntities("ResourceGroup_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eResourcegroupGrouptypecode
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
			public const string BusinessUnitId = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>grouptypecode</summary>
			public const string GroupTypeCode = "grouptypecode";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>objecttypecode</summary>
			public const string Entity = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>resourcegroupid</summary>
			public const string SchedulingGroupId = "resourcegroupid";

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
			/// <summary>1:N ResourceGroup_AsyncOperations</summary>
			public const string ResourceGroupAsyncOperations = "ResourceGroup_AsyncOperations";

			/// <summary>1:N ResourceGroup_BulkDeleteFailures</summary>
			public const string ResourceGroupBulkDeleteFailures = "ResourceGroup_BulkDeleteFailures";

			/// <summary>1:N resourcegroup_connections1</summary>
			public const string ResourcegroupConnections1 = "resourcegroup_connections1";

			/// <summary>1:N resourcegroup_connections2</summary>
			public const string ResourcegroupConnections2 = "resourcegroup_connections2";

			/// <summary>1:N ResourceGroup_DuplicateBaseRecord</summary>
			public const string ResourceGroupDuplicateBaseRecord = "ResourceGroup_DuplicateBaseRecord";

			/// <summary>1:N ResourceGroup_DuplicateMatchingRecord</summary>
			public const string ResourceGroupDuplicateMatchingRecord = "ResourceGroup_DuplicateMatchingRecord";

			/// <summary>1:N resourcegroup_MailboxTrackingFolders</summary>
			public const string ResourcegroupMailboxTrackingFolders = "resourcegroup_MailboxTrackingFolders";

			/// <summary>1:N resourcegroup_PrincipalObjectAttributeAccesses</summary>
			public const string ResourcegroupPrincipalObjectAttributeAccesses = "resourcegroup_PrincipalObjectAttributeAccesses";

			/// <summary>1:N ResourceGroup_SyncErrors</summary>
			public const string ResourceGroupSyncErrors = "ResourceGroup_SyncErrors";

		}
		#endregion
	}
}

