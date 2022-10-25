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
	[EntityLogicalName("catalogassignment")]
	public sealed class CatalogAssignment : Entity
	{	
		public static readonly int? EntityTypeCode = 10049;
		public new const string LogicalName = "catalogassignment";
		public const string PrimaryIdAttribute = "catalogassignmentid";
		public const string PrimaryNameAttribute = "name";
	
		public CatalogAssignment() : base("catalogassignment") { }

		#region Attributes
		/// <summary>
        /// catalogassignmentid
        /// </summary>
		[DisplayName("Catalog Assignment")]
		[AttributeLogicalName("catalogassignmentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("catalogassignmentid", value); }
		}

							/// <summary>
        /// catalogid
        /// </summary>
		[DisplayName("catalog")]
		[AttributeLogicalName("catalogid")]
		public EntityReference Catalog
		{	
			get { return GetAttributeValue<EntityReference>("catalogid"); }
			set
			{ 
				if(value == Catalog) return;
				SetAttributeValue("catalogid", value);
			}
		}	
			
		/// <summary>
        /// catalogidname
        /// </summary>
		[DisplayName("catalogidname")]
		[AttributeLogicalName("catalogidname")]
		public string Catalogidname
		{	
			get { return GetAttributeValue<string>("catalogidname"); }
			set
			{ 
				if(value == Catalogidname) return;
				SetAttributeValue("catalogidname", value);
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
        /// object
        /// </summary>
		[DisplayName("Catalog Assignment Object")]
		[AttributeLogicalName("object")]
		public EntityReference CatalogAssignmentObject
		{	
			get { return GetAttributeValue<EntityReference>("object"); }
			set
			{ 
				if(value == CatalogAssignmentObject) return;
				SetAttributeValue("object", value);
			}
		}	
			
		/// <summary>
        /// objectidtype
        /// </summary>
		[DisplayName("objectidtype")]
		[AttributeLogicalName("objectidtype")]
		public string Objectidtype
		{	
			get { return GetAttributeValue<string>("objectidtype"); }
			set
			{ 
				if(value == Objectidtype) return;
				SetAttributeValue("objectidtype", value);
			}
		}	
			
		/// <summary>
        /// objectname
        /// </summary>
		[DisplayName("objectname")]
		[AttributeLogicalName("objectname")]
		public string Objectname
		{	
			get { return GetAttributeValue<string>("objectname"); }
			set
			{ 
				if(value == Objectname) return;
				SetAttributeValue("objectname", value);
			}
		}	
			
		/// <summary>
        /// objectyominame
        /// </summary>
		[DisplayName("objectyominame")]
		[AttributeLogicalName("objectyominame")]
		public string Objectyominame
		{	
			get { return GetAttributeValue<string>("objectyominame"); }
			set
			{ 
				if(value == Objectyominame) return;
				SetAttributeValue("objectyominame", value);
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
        /// 1:N Get entities for 'catalogassignment_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_AsyncOperations")]
		public IEnumerable<SystemJob> CatalogassignmentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("catalogassignment_AsyncOperations", null); }
			set { SetRelatedEntities("catalogassignment_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CatalogassignmentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("catalogassignment_BulkDeleteFailures", null); }
			set { SetRelatedEntities("catalogassignment_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> CatalogassignmentDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("catalogassignment_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("catalogassignment_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> CatalogassignmentDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("catalogassignment_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("catalogassignment_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> CatalogassignmentMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("catalogassignment_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("catalogassignment_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> CatalogassignmentPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("catalogassignment_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("catalogassignment_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_ProcessSession")]
		public IEnumerable<ProcessSession> CatalogassignmentProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("catalogassignment_ProcessSession", null); }
			set { SetRelatedEntities("catalogassignment_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'catalogassignment_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_SyncErrors")]
		public IEnumerable<SyncError> CatalogassignmentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("catalogassignment_SyncErrors", null); }
			set { SetRelatedEntities("catalogassignment_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
			/// <summary>catalogassignmentid</summary>
			public const string CatalogAssignmentId = "catalogassignmentid";

			/// <summary>catalogid</summary>
			public const string Catalog = "catalogid";

			/// <summary>catalogidname</summary>
			public const string Catalogidname = "catalogidname";

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

			/// <summary>object</summary>
			public const string CatalogAssignmentObject = "object";

			/// <summary>objectidtype</summary>
			public const string Objectidtype = "objectidtype";

			/// <summary>objectname</summary>
			public const string Objectname = "objectname";

			/// <summary>objectyominame</summary>
			public const string Objectyominame = "objectyominame";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

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
			/// <summary>1:N catalogassignment_AsyncOperations</summary>
			public const string CatalogassignmentAsyncOperations = "catalogassignment_AsyncOperations";

			/// <summary>1:N catalogassignment_BulkDeleteFailures</summary>
			public const string CatalogassignmentBulkDeleteFailures = "catalogassignment_BulkDeleteFailures";

			/// <summary>1:N catalogassignment_DuplicateBaseRecord</summary>
			public const string CatalogassignmentDuplicateBaseRecord = "catalogassignment_DuplicateBaseRecord";

			/// <summary>1:N catalogassignment_DuplicateMatchingRecord</summary>
			public const string CatalogassignmentDuplicateMatchingRecord = "catalogassignment_DuplicateMatchingRecord";

			/// <summary>1:N catalogassignment_MailboxTrackingFolders</summary>
			public const string CatalogassignmentMailboxTrackingFolders = "catalogassignment_MailboxTrackingFolders";

			/// <summary>1:N catalogassignment_PrincipalObjectAttributeAccesses</summary>
			public const string CatalogassignmentPrincipalObjectAttributeAccesses = "catalogassignment_PrincipalObjectAttributeAccesses";

			/// <summary>1:N catalogassignment_ProcessSession</summary>
			public const string CatalogassignmentProcessSession = "catalogassignment_ProcessSession";

			/// <summary>1:N catalogassignment_SyncErrors</summary>
			public const string CatalogassignmentSyncErrors = "catalogassignment_SyncErrors";

		}
		#endregion
	}
}

