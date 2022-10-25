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
	[EntityLogicalName("serviceplan")]
	public sealed class ServicePlan : Entity
	{	
		public static readonly int? EntityTypeCode = 101;
		public new const string LogicalName = "serviceplan";
		public const string PrimaryIdAttribute = "serviceplanid";
		public const string PrimaryNameAttribute = "name";
	
		public ServicePlan() : base("serviceplan") { }

		#region Attributes
		/// <summary>
        /// accessmode
        /// </summary>
		[DisplayName("AccessMode")]
		[AttributeLogicalName("accessmode")]
		public eAccessMode? AccessMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accessmode");
				if (optionSetValue != null) return (eAccessMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AccessMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accessmode", optionSetValue); 
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
        /// serviceplanid
        /// </summary>
		[DisplayName("Service Plan")]
		[AttributeLogicalName("serviceplanid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("serviceplanid", value); }
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
        /// 1:N Get entities for 'serviceplan_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("serviceplan_AsyncOperations")]
		public IEnumerable<SystemJob> ServiceplanAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("serviceplan_AsyncOperations", null); }
			set { SetRelatedEntities("serviceplan_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("serviceplan_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ServiceplanBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("serviceplan_BulkDeleteFailures", null); }
			set { SetRelatedEntities("serviceplan_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("serviceplan_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ServiceplanDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("serviceplan_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("serviceplan_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("serviceplan_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ServiceplanDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("serviceplan_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("serviceplan_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("serviceplan_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ServiceplanMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("serviceplan_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("serviceplan_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("serviceplan_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ServiceplanPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("serviceplan_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("serviceplan_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("serviceplan_ProcessSession")]
		public IEnumerable<ProcessSession> ServiceplanProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("serviceplan_ProcessSession", null); }
			set { SetRelatedEntities("serviceplan_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceplan_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("serviceplan_SyncErrors")]
		public IEnumerable<SyncError> ServiceplanSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("serviceplan_SyncErrors", null); }
			set { SetRelatedEntities("serviceplan_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'ModeldrivenApp'
        /// </summary>
		[RelationshipSchemaName("serviceplan_appmodule")]
		public IEnumerable<ModeldrivenApp> ServiceplanAppmodule
		{
			get { return GetRelatedEntities<ModeldrivenApp>("serviceplan_appmodule", null); }
			set { SetRelatedEntities("serviceplan_appmodule", null, value); }
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
		
		public enum eAccessMode
		{	
		
			[Label("Custom applications")]
			[Description(@"")]
			CustomApplications = 0, 
		
			[Label("First party applications")]
			[Description(@"")]
			FirstPartyApplications = 1, 
		
			[Label("First party and Custom applications")]
			[Description(@"")]
			FirstPartyAndCustomApplications = 2, 
		
			[Label("All applications")]
			[Description(@"")]
			AllApplications = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accessmode</summary>
			public const string AccessMode = "accessmode";

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

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>serviceplanid</summary>
			public const string ServicePlanId = "serviceplanid";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

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
			/// <summary>1:N serviceplan_AsyncOperations</summary>
			public const string ServiceplanAsyncOperations = "serviceplan_AsyncOperations";

			/// <summary>1:N serviceplan_BulkDeleteFailures</summary>
			public const string ServiceplanBulkDeleteFailures = "serviceplan_BulkDeleteFailures";

			/// <summary>1:N serviceplan_DuplicateBaseRecord</summary>
			public const string ServiceplanDuplicateBaseRecord = "serviceplan_DuplicateBaseRecord";

			/// <summary>1:N serviceplan_DuplicateMatchingRecord</summary>
			public const string ServiceplanDuplicateMatchingRecord = "serviceplan_DuplicateMatchingRecord";

			/// <summary>1:N serviceplan_MailboxTrackingFolders</summary>
			public const string ServiceplanMailboxTrackingFolders = "serviceplan_MailboxTrackingFolders";

			/// <summary>1:N serviceplan_PrincipalObjectAttributeAccesses</summary>
			public const string ServiceplanPrincipalObjectAttributeAccesses = "serviceplan_PrincipalObjectAttributeAccesses";

			/// <summary>1:N serviceplan_ProcessSession</summary>
			public const string ServiceplanProcessSession = "serviceplan_ProcessSession";

			/// <summary>1:N serviceplan_SyncErrors</summary>
			public const string ServiceplanSyncErrors = "serviceplan_SyncErrors";

			/// <summary>N:N serviceplan_appmodule</summary>
			public const string ServiceplanAppmodule = "serviceplan_appmodule";

		}
		#endregion
	}
}

