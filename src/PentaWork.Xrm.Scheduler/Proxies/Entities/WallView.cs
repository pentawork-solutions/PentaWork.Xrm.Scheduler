using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntityName}")] 	
	[EntityLogicalName("msdyn_wallsavedquery")]
	public sealed class WallView : Entity
	{	
		public static readonly int? EntityTypeCode = 10104;
		public new const string LogicalName = "msdyn_wallsavedquery";
		public const string PrimaryIdAttribute = "msdyn_wallsavedqueryid";
		public const string PrimaryNameAttribute = "msdyn_entityname";
	
		public WallView() : base("msdyn_wallsavedquery") { }

		#region Attributes
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
        /// msdyn_entitydisplayname
        /// </summary>
		[DisplayName("Entity Display Name")]
		[AttributeLogicalName("msdyn_entitydisplayname")]
		public string EntityDisplayName
		{	
			get { return GetAttributeValue<string>("msdyn_entitydisplayname"); }
			set
			{ 
				if(value == EntityDisplayName) return;
				SetAttributeValue("msdyn_entitydisplayname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_entityname
        /// </summary>
		[DisplayName("Entity Name")]
		[AttributeLogicalName("msdyn_entityname")]
		public string EntityName
		{	
			get { return GetAttributeValue<string>("msdyn_entityname"); }
			set
			{ 
				if(value == EntityName) return;
				SetAttributeValue("msdyn_entityname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isvirtual
        /// </summary>
		[DisplayName("Is Virtual")]
		[AttributeLogicalName("msdyn_isvirtual")]
		public bool? IsVirtual
		{	
			get { return GetAttributeValue<bool?>("msdyn_isvirtual"); }
			set
			{ 
				if(value == IsVirtual) return;
				SetAttributeValue("msdyn_isvirtual", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isvisible
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("msdyn_isvisible")]
		public bool? Status
		{	
			get { return GetAttributeValue<bool?>("msdyn_isvisible"); }
			set
			{ 
				if(value == Status) return;
				SetAttributeValue("msdyn_isvisible", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isvisiblebit
        /// </summary>
		[DisplayName("Is Visible bit")]
		[AttributeLogicalName("msdyn_isvisiblebit")]
		public int? IsVisibleBit
		{	
			get { return GetAttributeValue<int?>("msdyn_isvisiblebit"); }
			set
			{ 
				if(value == IsVisibleBit) return;
				SetAttributeValue("msdyn_isvisiblebit", value);
			}
		}	
			
		/// <summary>
        /// msdyn_otc
        /// </summary>
		[DisplayName("Entity Type")]
		[AttributeLogicalName("msdyn_otc")]
		public int? EntityType
		{	
			get { return GetAttributeValue<int?>("msdyn_otc"); }
			set
			{ 
				if(value == EntityType) return;
				SetAttributeValue("msdyn_otc", value);
			}
		}	
			
		/// <summary>
        /// msdyn_postconfigurationid
        /// </summary>
		[DisplayName("Post Entity Id")]
		[AttributeLogicalName("msdyn_postconfigurationid")]
		public EntityReference PostEntityId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_postconfigurationid"); }
			set
			{ 
				if(value == PostEntityId) return;
				SetAttributeValue("msdyn_postconfigurationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_postconfigurationidname
        /// </summary>
		[DisplayName("msdyn_postconfigurationidname")]
		[AttributeLogicalName("msdyn_postconfigurationidname")]
		public string MsdynPostconfigurationidname
		{	
			get { return GetAttributeValue<string>("msdyn_postconfigurationidname"); }
			set
			{ 
				if(value == MsdynPostconfigurationidname) return;
				SetAttributeValue("msdyn_postconfigurationidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_savedqueryid
        /// </summary>
		[DisplayName("View Id")]
		[AttributeLogicalName("msdyn_savedqueryid")]
		public string ViewId
		{	
			get { return GetAttributeValue<string>("msdyn_savedqueryid"); }
			set
			{ 
				if(value == ViewId) return;
				SetAttributeValue("msdyn_savedqueryid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_savedqueryname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_savedqueryname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_savedqueryname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_savedqueryname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_wallsavedqueryid
        /// </summary>
		[DisplayName("Wall View")]
		[AttributeLogicalName("msdyn_wallsavedqueryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_wallsavedqueryid", value); }
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
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStatus? Status2
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status2) return;

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
        /// 1:N Get entities for 'msdyn_wallsavedquery_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynWallsavedqueryAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_wallsavedquery_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedquery_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynWallsavedqueryBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedquery_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedquery_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynWallsavedqueryMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_wallsavedquery_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedquery_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynWallsavedqueryPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedquery_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynWallsavedqueryProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_wallsavedquery_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedquery_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_SyncErrors")]
		public IEnumerable<SyncError> MsdynWallsavedquerySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_wallsavedquery_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedquery_wallsavedqueryusersettings'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedquery_wallsavedqueryusersettings")]
		public IEnumerable<Filter> MsdynWallsavedqueryWallsavedqueryusersettings
		{
			get { return GetRelatedEntities<Filter>("msdyn_wallsavedquery_wallsavedqueryusersettings", null); }
			set { SetRelatedEntities("msdyn_wallsavedquery_wallsavedqueryusersettings", null, value); }
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>msdyn_entitydisplayname</summary>
			public const string EntityDisplayName = "msdyn_entitydisplayname";

			/// <summary>msdyn_entityname</summary>
			public const string EntityName = "msdyn_entityname";

			/// <summary>msdyn_isvirtual</summary>
			public const string IsVirtual = "msdyn_isvirtual";

			/// <summary>msdyn_isvisible</summary>
			public const string Status = "msdyn_isvisible";

			/// <summary>msdyn_isvisiblebit</summary>
			public const string IsVisibleBit = "msdyn_isvisiblebit";

			/// <summary>msdyn_otc</summary>
			public const string EntityType = "msdyn_otc";

			/// <summary>msdyn_postconfigurationid</summary>
			public const string PostEntityId = "msdyn_postconfigurationid";

			/// <summary>msdyn_postconfigurationidname</summary>
			public const string MsdynPostconfigurationidname = "msdyn_postconfigurationidname";

			/// <summary>msdyn_savedqueryid</summary>
			public const string ViewId = "msdyn_savedqueryid";

			/// <summary>msdyn_savedqueryname</summary>
			public const string Name = "msdyn_savedqueryname";

			/// <summary>msdyn_wallsavedqueryid</summary>
			public const string WallViewId = "msdyn_wallsavedqueryid";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>statecode</summary>
			public const string Status2 = "statecode";

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
			/// <summary>1:N msdyn_wallsavedquery_AsyncOperations</summary>
			public const string MsdynWallsavedqueryAsyncOperations = "msdyn_wallsavedquery_AsyncOperations";

			/// <summary>1:N msdyn_wallsavedquery_BulkDeleteFailures</summary>
			public const string MsdynWallsavedqueryBulkDeleteFailures = "msdyn_wallsavedquery_BulkDeleteFailures";

			/// <summary>1:N msdyn_wallsavedquery_MailboxTrackingFolders</summary>
			public const string MsdynWallsavedqueryMailboxTrackingFolders = "msdyn_wallsavedquery_MailboxTrackingFolders";

			/// <summary>1:N msdyn_wallsavedquery_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynWallsavedqueryPrincipalObjectAttributeAccesses = "msdyn_wallsavedquery_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_wallsavedquery_ProcessSession</summary>
			public const string MsdynWallsavedqueryProcessSession = "msdyn_wallsavedquery_ProcessSession";

			/// <summary>1:N msdyn_wallsavedquery_SyncErrors</summary>
			public const string MsdynWallsavedquerySyncErrors = "msdyn_wallsavedquery_SyncErrors";

			/// <summary>1:N msdyn_wallsavedquery_wallsavedqueryusersettings</summary>
			public const string MsdynWallsavedqueryWallsavedqueryusersettings = "msdyn_wallsavedquery_wallsavedqueryusersettings";

		}
		#endregion
	}
}

