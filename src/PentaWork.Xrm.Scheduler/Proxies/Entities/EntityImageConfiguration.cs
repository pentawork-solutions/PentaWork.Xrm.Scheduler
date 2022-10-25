using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ParentEntityLogicalName}")] 	
	[EntityLogicalName("entityimageconfig")]
	public sealed class EntityImageConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 432;
		public new const string LogicalName = "entityimageconfig";
		public const string PrimaryIdAttribute = "entityimageconfigid";
		public const string PrimaryNameAttribute = "parententitylogicalname";
	
		public EntityImageConfiguration() : base("entityimageconfig") { }

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
        /// entityimageconfigid
        /// </summary>
		[DisplayName("Entity Image Configuration")]
		[AttributeLogicalName("entityimageconfigid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entityimageconfigid", value); }
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
        /// parententitylogicalname
        /// </summary>
		[DisplayName("Parent Entity Logical Name")]
		[AttributeLogicalName("parententitylogicalname")]
		public string ParentEntityLogicalName
		{	
			get { return GetAttributeValue<string>("parententitylogicalname"); }
			set
			{ 
				if(value == ParentEntityLogicalName) return;
				SetAttributeValue("parententitylogicalname", value);
			}
		}	
			
		/// <summary>
        /// primaryimageattribute
        /// </summary>
		[DisplayName("Primary Image Attribute")]
		[AttributeLogicalName("primaryimageattribute")]
		public string PrimaryImageAttribute
		{	
			get { return GetAttributeValue<string>("primaryimageattribute"); }
			set
			{ 
				if(value == PrimaryImageAttribute) return;
				SetAttributeValue("primaryimageattribute", value);
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
        /// 1:N Get entities for 'entityimageconfig_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entityimageconfig_AsyncOperations")]
		public IEnumerable<SystemJob> EntityimageconfigAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entityimageconfig_AsyncOperations", null); }
			set { SetRelatedEntities("entityimageconfig_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityimageconfig_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entityimageconfig_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntityimageconfigBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entityimageconfig_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entityimageconfig_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityimageconfig_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("entityimageconfig_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EntityimageconfigMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("entityimageconfig_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("entityimageconfig_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityimageconfig_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entityimageconfig_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntityimageconfigPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entityimageconfig_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entityimageconfig_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entityimageconfig_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("entityimageconfig_SyncErrors")]
		public IEnumerable<SyncError> EntityimageconfigSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("entityimageconfig_SyncErrors", null); }
			set { SetRelatedEntities("entityimageconfig_SyncErrors", null, value); }
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

			/// <summary>entityimageconfigid</summary>
			public const string EntityImageConfigurationId = "entityimageconfigid";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>parententitylogicalname</summary>
			public const string ParentEntityLogicalName = "parententitylogicalname";

			/// <summary>primaryimageattribute</summary>
			public const string PrimaryImageAttribute = "primaryimageattribute";

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
			/// <summary>1:N entityimageconfig_AsyncOperations</summary>
			public const string EntityimageconfigAsyncOperations = "entityimageconfig_AsyncOperations";

			/// <summary>1:N entityimageconfig_BulkDeleteFailures</summary>
			public const string EntityimageconfigBulkDeleteFailures = "entityimageconfig_BulkDeleteFailures";

			/// <summary>1:N entityimageconfig_MailboxTrackingFolders</summary>
			public const string EntityimageconfigMailboxTrackingFolders = "entityimageconfig_MailboxTrackingFolders";

			/// <summary>1:N entityimageconfig_PrincipalObjectAttributeAccesses</summary>
			public const string EntityimageconfigPrincipalObjectAttributeAccesses = "entityimageconfig_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entityimageconfig_SyncErrors</summary>
			public const string EntityimageconfigSyncErrors = "entityimageconfig_SyncErrors";

		}
		#endregion
	}
}

