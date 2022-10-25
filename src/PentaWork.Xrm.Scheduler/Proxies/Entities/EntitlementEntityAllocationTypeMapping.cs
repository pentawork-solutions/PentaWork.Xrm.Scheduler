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
	[EntityLogicalName("entitlemententityallocationtypemapping")]
	public sealed class EntitlementEntityAllocationTypeMapping : Entity
	{	
		public static readonly int? EntityTypeCode = 9704;
		public new const string LogicalName = "entitlemententityallocationtypemapping";
		public const string PrimaryIdAttribute = "entitlemententityallocationtypemappingid";
		public const string PrimaryNameAttribute = "name";
	
		public EntitlementEntityAllocationTypeMapping() : base("entitlemententityallocationtypemapping") { }

		#region Attributes
		/// <summary>
        /// allocationtype
        /// </summary>
		[DisplayName("Allocation Type")]
		[AttributeLogicalName("allocationtype")]
		public egAllocationType? AllocationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allocationtype");
				if (optionSetValue != null) return (egAllocationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AllocationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allocationtype", optionSetValue); 
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
        /// entitlemententityallocationtypemappingid
        /// </summary>
		[DisplayName("Entitlement Entity Allocation Type Mapping")]
		[AttributeLogicalName("entitlemententityallocationtypemappingid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entitlemententityallocationtypemappingid", value); }
		}

							/// <summary>
        /// entitytype
        /// </summary>
		[DisplayName("Entity Type")]
		[AttributeLogicalName("entitytype")]
		public egEntityType? EntityType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("entitytype");
				if (optionSetValue != null) return (egEntityType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EntityType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("entitytype", optionSetValue); 
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
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_AsyncOperations")]
		public IEnumerable<SystemJob> EntitlemententityallocationtypemappingAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entitlemententityallocationtypemapping_AsyncOperations", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntitlemententityallocationtypemappingBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entitlemententityallocationtypemapping_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EntitlemententityallocationtypemappingDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlemententityallocationtypemapping_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EntitlemententityallocationtypemappingDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlemententityallocationtypemapping_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EntitlemententityallocationtypemappingMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("entitlemententityallocationtypemapping_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntitlemententityallocationtypemappingPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entitlemententityallocationtypemapping_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_ProcessSession")]
		public IEnumerable<ProcessSession> EntitlemententityallocationtypemappingProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("entitlemententityallocationtypemapping_ProcessSession", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlemententityallocationtypemapping_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("entitlemententityallocationtypemapping_SyncErrors")]
		public IEnumerable<SyncError> EntitlemententityallocationtypemappingSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("entitlemententityallocationtypemapping_SyncErrors", null); }
			set { SetRelatedEntities("entitlemententityallocationtypemapping_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egAllocationType
		{	
		
			[Label("Number of cases")]
			[Description(@"")]
			NumberOfCases = 0, 
		
			[Label("Number of hours")]
			[Description(@"")]
			NumberOfHours = 1, 
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
		
		public enum egEntityType
		{	
		
			[Label("Case")]
			[Description(@"")]
			Case = 0, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>allocationtype</summary>
			public const string AllocationType = "allocationtype";

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

			/// <summary>entitlemententityallocationtypemappingid</summary>
			public const string EntitlementEntityAllocationTypeMappingId = "entitlemententityallocationtypemappingid";

			/// <summary>entitytype</summary>
			public const string EntityType = "entitytype";

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

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

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
			/// <summary>1:N entitlemententityallocationtypemapping_AsyncOperations</summary>
			public const string EntitlemententityallocationtypemappingAsyncOperations = "entitlemententityallocationtypemapping_AsyncOperations";

			/// <summary>1:N entitlemententityallocationtypemapping_BulkDeleteFailures</summary>
			public const string EntitlemententityallocationtypemappingBulkDeleteFailures = "entitlemententityallocationtypemapping_BulkDeleteFailures";

			/// <summary>1:N entitlemententityallocationtypemapping_DuplicateBaseRecord</summary>
			public const string EntitlemententityallocationtypemappingDuplicateBaseRecord = "entitlemententityallocationtypemapping_DuplicateBaseRecord";

			/// <summary>1:N entitlemententityallocationtypemapping_DuplicateMatchingRecord</summary>
			public const string EntitlemententityallocationtypemappingDuplicateMatchingRecord = "entitlemententityallocationtypemapping_DuplicateMatchingRecord";

			/// <summary>1:N entitlemententityallocationtypemapping_MailboxTrackingFolders</summary>
			public const string EntitlemententityallocationtypemappingMailboxTrackingFolders = "entitlemententityallocationtypemapping_MailboxTrackingFolders";

			/// <summary>1:N entitlemententityallocationtypemapping_PrincipalObjectAttributeAccesses</summary>
			public const string EntitlemententityallocationtypemappingPrincipalObjectAttributeAccesses = "entitlemententityallocationtypemapping_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entitlemententityallocationtypemapping_ProcessSession</summary>
			public const string EntitlemententityallocationtypemappingProcessSession = "entitlemententityallocationtypemapping_ProcessSession";

			/// <summary>1:N entitlemententityallocationtypemapping_SyncErrors</summary>
			public const string EntitlemententityallocationtypemappingSyncErrors = "entitlemententityallocationtypemapping_SyncErrors";

		}
		#endregion
	}
}

