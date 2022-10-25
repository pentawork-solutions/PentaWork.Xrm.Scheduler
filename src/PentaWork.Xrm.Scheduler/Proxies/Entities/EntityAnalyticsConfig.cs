using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntityLogicalNameForAnalytics}")] 	
	[EntityLogicalName("entityanalyticsconfig")]
	public sealed class EntityAnalyticsConfig : Entity
	{	
		public static readonly int? EntityTypeCode = 430;
		public new const string LogicalName = "entityanalyticsconfig";
		public const string PrimaryIdAttribute = "entityanalyticsconfigid";
		public const string PrimaryNameAttribute = "parententitylogicalname";
	
		public EntityAnalyticsConfig() : base("entityanalyticsconfig") { }

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
        /// entityanalyticsconfigid
        /// </summary>
		[DisplayName("Entity Analytics Config")]
		[AttributeLogicalName("entityanalyticsconfigid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entityanalyticsconfigid", value); }
		}

							/// <summary>
        /// isenabledforadls
        /// </summary>
		[DisplayName("Is Enabled For ADLS")]
		[AttributeLogicalName("isenabledforadls")]
		public bool? IsEnabledForADLS
		{	
			get { return GetAttributeValue<bool?>("isenabledforadls"); }
			set
			{ 
				if(value == IsEnabledForADLS) return;
				SetAttributeValue("isenabledforadls", value);
			}
		}	
			
		/// <summary>
        /// isenabledfortimeseries
        /// </summary>
		[DisplayName("Is Enabled For Time Series")]
		[AttributeLogicalName("isenabledfortimeseries")]
		public bool? IsEnabledForTimeSeries
		{	
			get { return GetAttributeValue<bool?>("isenabledfortimeseries"); }
			set
			{ 
				if(value == IsEnabledForTimeSeries) return;
				SetAttributeValue("isenabledfortimeseries", value);
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
        /// parententityid
        /// </summary>
		[DisplayName("Parent Entity Id")]
		[AttributeLogicalName("parententityid")]
		public EntityReference ParentEntityId
		{	
			get { return GetAttributeValue<EntityReference>("parententityid"); }
			set
			{ 
				if(value == ParentEntityId) return;
				SetAttributeValue("parententityid", value);
			}
		}	
			
		/// <summary>
        /// parententityidname
        /// </summary>
		[DisplayName("parententityidname")]
		[AttributeLogicalName("parententityidname")]
		public string Parententityidname
		{	
			get { return GetAttributeValue<string>("parententityidname"); }
			set
			{ 
				if(value == Parententityidname) return;
				SetAttributeValue("parententityidname", value);
			}
		}	
			
		/// <summary>
        /// parententitylogicalname
        /// </summary>
		[DisplayName("Entity Logical Name For Analytics")]
		[AttributeLogicalName("parententitylogicalname")]
		public string EntityLogicalNameForAnalytics
		{	
			get { return GetAttributeValue<string>("parententitylogicalname"); }
			set
			{ 
				if(value == EntityLogicalNameForAnalytics) return;
				SetAttributeValue("parententitylogicalname", value);
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
        /// 1:N Get entities for 'entityanalyticsconfig_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entityanalyticsconfig_AsyncOperations")]
		public IEnumerable<SystemJob> EntityanalyticsconfigAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entityanalyticsconfig_AsyncOperations", null); }
			set { SetRelatedEntities("entityanalyticsconfig_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityanalyticsconfig_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entityanalyticsconfig_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntityanalyticsconfigBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entityanalyticsconfig_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entityanalyticsconfig_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityanalyticsconfig_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("entityanalyticsconfig_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EntityanalyticsconfigMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("entityanalyticsconfig_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("entityanalyticsconfig_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityanalyticsconfig_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entityanalyticsconfig_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntityanalyticsconfigPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entityanalyticsconfig_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entityanalyticsconfig_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityanalyticsconfig_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("entityanalyticsconfig_SyncErrors")]
		public IEnumerable<SyncError> EntityanalyticsconfigSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("entityanalyticsconfig_SyncErrors", null); }
			set { SetRelatedEntities("entityanalyticsconfig_SyncErrors", null, value); }
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>entityanalyticsconfigid</summary>
			public const string EntityAnalyticsConfigId = "entityanalyticsconfigid";

			/// <summary>isenabledforadls</summary>
			public const string IsEnabledForADLS = "isenabledforadls";

			/// <summary>isenabledfortimeseries</summary>
			public const string IsEnabledForTimeSeries = "isenabledfortimeseries";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>parententityid</summary>
			public const string ParentEntityId = "parententityid";

			/// <summary>parententityidname</summary>
			public const string Parententityidname = "parententityidname";

			/// <summary>parententitylogicalname</summary>
			public const string EntityLogicalNameForAnalytics = "parententitylogicalname";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N entityanalyticsconfig_AsyncOperations</summary>
			public const string EntityanalyticsconfigAsyncOperations = "entityanalyticsconfig_AsyncOperations";

			/// <summary>1:N entityanalyticsconfig_BulkDeleteFailures</summary>
			public const string EntityanalyticsconfigBulkDeleteFailures = "entityanalyticsconfig_BulkDeleteFailures";

			/// <summary>1:N entityanalyticsconfig_MailboxTrackingFolders</summary>
			public const string EntityanalyticsconfigMailboxTrackingFolders = "entityanalyticsconfig_MailboxTrackingFolders";

			/// <summary>1:N entityanalyticsconfig_PrincipalObjectAttributeAccesses</summary>
			public const string EntityanalyticsconfigPrincipalObjectAttributeAccesses = "entityanalyticsconfig_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entityanalyticsconfig_SyncErrors</summary>
			public const string EntityanalyticsconfigSyncErrors = "entityanalyticsconfig_SyncErrors";

		}
		#endregion
	}
}

