using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{LogicalNameOfImageAttribute}")] 	
	[EntityLogicalName("attributeimageconfig")]
	public sealed class ImageAttributeConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 431;
		public new const string LogicalName = "attributeimageconfig";
		public const string PrimaryIdAttribute = "attributeimageconfigid";
		public const string PrimaryNameAttribute = "attributelogicalname";
	
		public ImageAttributeConfiguration() : base("attributeimageconfig") { }

		#region Attributes
		/// <summary>
        /// attributeimageconfigid
        /// </summary>
		[DisplayName("Image Attribute Configuration")]
		[AttributeLogicalName("attributeimageconfigid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("attributeimageconfigid", value); }
		}

							/// <summary>
        /// attributelogicalname
        /// </summary>
		[DisplayName("Logical Name of Image Attribute")]
		[AttributeLogicalName("attributelogicalname")]
		public string LogicalNameOfImageAttribute
		{	
			get { return GetAttributeValue<string>("attributelogicalname"); }
			set
			{ 
				if(value == LogicalNameOfImageAttribute) return;
				SetAttributeValue("attributelogicalname", value);
			}
		}	
			
		/// <summary>
        /// canstorefullimage
        /// </summary>
		[DisplayName("Can Store Full Image")]
		[AttributeLogicalName("canstorefullimage")]
		public bool? CanStoreFullImage
		{	
			get { return GetAttributeValue<bool?>("canstorefullimage"); }
			set
			{ 
				if(value == CanStoreFullImage) return;
				SetAttributeValue("canstorefullimage", value);
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
        /// 1:N Get entities for 'attributeimageconfig_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("attributeimageconfig_AsyncOperations")]
		public IEnumerable<SystemJob> AttributeimageconfigAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("attributeimageconfig_AsyncOperations", null); }
			set { SetRelatedEntities("attributeimageconfig_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'attributeimageconfig_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("attributeimageconfig_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> AttributeimageconfigBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("attributeimageconfig_BulkDeleteFailures", null); }
			set { SetRelatedEntities("attributeimageconfig_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'attributeimageconfig_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("attributeimageconfig_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> AttributeimageconfigMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("attributeimageconfig_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("attributeimageconfig_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'attributeimageconfig_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("attributeimageconfig_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> AttributeimageconfigPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("attributeimageconfig_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("attributeimageconfig_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'attributeimageconfig_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("attributeimageconfig_SyncErrors")]
		public IEnumerable<SyncError> AttributeimageconfigSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("attributeimageconfig_SyncErrors", null); }
			set { SetRelatedEntities("attributeimageconfig_SyncErrors", null, value); }
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
			/// <summary>attributeimageconfigid</summary>
			public const string ImageAttributeConfigurationId = "attributeimageconfigid";

			/// <summary>attributelogicalname</summary>
			public const string LogicalNameOfImageAttribute = "attributelogicalname";

			/// <summary>canstorefullimage</summary>
			public const string CanStoreFullImage = "canstorefullimage";

			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>parententitylogicalname</summary>
			public const string ParentEntityLogicalName = "parententitylogicalname";

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
			/// <summary>1:N attributeimageconfig_AsyncOperations</summary>
			public const string AttributeimageconfigAsyncOperations = "attributeimageconfig_AsyncOperations";

			/// <summary>1:N attributeimageconfig_BulkDeleteFailures</summary>
			public const string AttributeimageconfigBulkDeleteFailures = "attributeimageconfig_BulkDeleteFailures";

			/// <summary>1:N attributeimageconfig_MailboxTrackingFolders</summary>
			public const string AttributeimageconfigMailboxTrackingFolders = "attributeimageconfig_MailboxTrackingFolders";

			/// <summary>1:N attributeimageconfig_PrincipalObjectAttributeAccesses</summary>
			public const string AttributeimageconfigPrincipalObjectAttributeAccesses = "attributeimageconfig_PrincipalObjectAttributeAccesses";

			/// <summary>1:N attributeimageconfig_SyncErrors</summary>
			public const string AttributeimageconfigSyncErrors = "attributeimageconfig_SyncErrors";

		}
		#endregion
	}
}

