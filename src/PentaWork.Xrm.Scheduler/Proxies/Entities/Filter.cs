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
	[EntityLogicalName("msdyn_wallsavedqueryusersettings")]
	public sealed class Filter : Entity
	{	
		public static readonly int? EntityTypeCode = 10105;
		public new const string LogicalName = "msdyn_wallsavedqueryusersettings";
		public const string PrimaryIdAttribute = "msdyn_wallsavedqueryusersettingsid";
		public const string PrimaryNameAttribute = "msdyn_entityname";
	
		public Filter() : base("msdyn_wallsavedqueryusersettings") { }

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
        /// msdyn_data
        /// </summary>
		[DisplayName("Data")]
		[AttributeLogicalName("msdyn_data")]
		public string Data
		{	
			get { return GetAttributeValue<string>("msdyn_data"); }
			set
			{ 
				if(value == Data) return;
				SetAttributeValue("msdyn_data", value);
			}
		}	
			
		/// <summary>
        /// msdyn_default
        /// </summary>
		[DisplayName("Default")]
		[AttributeLogicalName("msdyn_default")]
		public int? Default
		{	
			get { return GetAttributeValue<int?>("msdyn_default"); }
			set
			{ 
				if(value == Default) return;
				SetAttributeValue("msdyn_default", value);
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
        /// msdyn_includewallinresponse
        /// </summary>
		[DisplayName("Include Wall in response")]
		[AttributeLogicalName("msdyn_includewallinresponse")]
		public bool? IncludeWallInResponse
		{	
			get { return GetAttributeValue<bool?>("msdyn_includewallinresponse"); }
			set
			{ 
				if(value == IncludeWallInResponse) return;
				SetAttributeValue("msdyn_includewallinresponse", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isfollowing
        /// </summary>
		[DisplayName("Is Following")]
		[AttributeLogicalName("msdyn_isfollowing")]
		public bool? IsFollowing
		{	
			get { return GetAttributeValue<bool?>("msdyn_isfollowing"); }
			set
			{ 
				if(value == IsFollowing) return;
				SetAttributeValue("msdyn_isfollowing", value);
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
		[DisplayName("Display on the wall")]
		[AttributeLogicalName("msdyn_isvisible")]
		public bool? DisplayOnTheWall
		{	
			get { return GetAttributeValue<bool?>("msdyn_isvisible"); }
			set
			{ 
				if(value == DisplayOnTheWall) return;
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
        /// msdyn_savedqueryname
        /// </summary>
		[DisplayName("View Name")]
		[AttributeLogicalName("msdyn_savedqueryname")]
		public string ViewName
		{	
			get { return GetAttributeValue<string>("msdyn_savedqueryname"); }
			set
			{ 
				if(value == ViewName) return;
				SetAttributeValue("msdyn_savedqueryname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sortorder
        /// </summary>
		[DisplayName("Sort Order")]
		[AttributeLogicalName("msdyn_sortorder")]
		public int? SortOrder
		{	
			get { return GetAttributeValue<int?>("msdyn_sortorder"); }
			set
			{ 
				if(value == SortOrder) return;
				SetAttributeValue("msdyn_sortorder", value);
			}
		}	
			
		/// <summary>
        /// msdyn_type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("msdyn_type")]
		public int? Type
		{	
			get { return GetAttributeValue<int?>("msdyn_type"); }
			set
			{ 
				if(value == Type) return;
				SetAttributeValue("msdyn_type", value);
			}
		}	
			
		/// <summary>
        /// msdyn_userid
        /// </summary>
		[DisplayName("User Id")]
		[AttributeLogicalName("msdyn_userid")]
		public EntityReference UserId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_userid"); }
			set
			{ 
				if(value == UserId) return;
				SetAttributeValue("msdyn_userid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_useridname
        /// </summary>
		[DisplayName("msdyn_useridname")]
		[AttributeLogicalName("msdyn_useridname")]
		public string MsdynUseridname
		{	
			get { return GetAttributeValue<string>("msdyn_useridname"); }
			set
			{ 
				if(value == MsdynUseridname) return;
				SetAttributeValue("msdyn_useridname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_useridyominame
        /// </summary>
		[DisplayName("msdyn_useridyominame")]
		[AttributeLogicalName("msdyn_useridyominame")]
		public string MsdynUseridyominame
		{	
			get { return GetAttributeValue<string>("msdyn_useridyominame"); }
			set
			{ 
				if(value == MsdynUseridyominame) return;
				SetAttributeValue("msdyn_useridyominame", value);
			}
		}	
			
		/// <summary>
        /// msdyn_wallsavedqueryid
        /// </summary>
		[DisplayName("Wall View Id")]
		[AttributeLogicalName("msdyn_wallsavedqueryid")]
		public EntityReference WallViewId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_wallsavedqueryid"); }
			set
			{ 
				if(value == WallViewId) return;
				SetAttributeValue("msdyn_wallsavedqueryid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_wallsavedqueryidname
        /// </summary>
		[DisplayName("msdyn_wallsavedqueryidname")]
		[AttributeLogicalName("msdyn_wallsavedqueryidname")]
		public string MsdynWallsavedqueryidname
		{	
			get { return GetAttributeValue<string>("msdyn_wallsavedqueryidname"); }
			set
			{ 
				if(value == MsdynWallsavedqueryidname) return;
				SetAttributeValue("msdyn_wallsavedqueryidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_wallsavedqueryusersettingsid
        /// </summary>
		[DisplayName("Filter")]
		[AttributeLogicalName("msdyn_wallsavedqueryusersettingsid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_wallsavedqueryusersettingsid", value); }
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
        /// 1:N Get entities for 'msdyn_wallsavedqueryusersettings_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedqueryusersettings_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynWallsavedqueryusersettingsAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_wallsavedqueryusersettings_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_wallsavedqueryusersettings_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedqueryusersettings_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedqueryusersettings_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynWallsavedqueryusersettingsBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedqueryusersettings_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedqueryusersettings_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynWallsavedqueryusersettingsMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_wallsavedqueryusersettings_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_wallsavedqueryusersettings_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedqueryusersettings_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedqueryusersettings_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynWallsavedqueryusersettingsProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_wallsavedqueryusersettings_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_wallsavedqueryusersettings_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_wallsavedqueryusersettings_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_wallsavedqueryusersettings_SyncErrors")]
		public IEnumerable<SyncError> MsdynWallsavedqueryusersettingsSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_wallsavedqueryusersettings_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_wallsavedqueryusersettings_SyncErrors", null, value); }
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

			/// <summary>msdyn_data</summary>
			public const string Data = "msdyn_data";

			/// <summary>msdyn_default</summary>
			public const string Default = "msdyn_default";

			/// <summary>msdyn_entitydisplayname</summary>
			public const string EntityDisplayName = "msdyn_entitydisplayname";

			/// <summary>msdyn_entityname</summary>
			public const string EntityName = "msdyn_entityname";

			/// <summary>msdyn_includewallinresponse</summary>
			public const string IncludeWallInResponse = "msdyn_includewallinresponse";

			/// <summary>msdyn_isfollowing</summary>
			public const string IsFollowing = "msdyn_isfollowing";

			/// <summary>msdyn_isvirtual</summary>
			public const string IsVirtual = "msdyn_isvirtual";

			/// <summary>msdyn_isvisible</summary>
			public const string DisplayOnTheWall = "msdyn_isvisible";

			/// <summary>msdyn_isvisiblebit</summary>
			public const string IsVisibleBit = "msdyn_isvisiblebit";

			/// <summary>msdyn_otc</summary>
			public const string EntityType = "msdyn_otc";

			/// <summary>msdyn_savedqueryname</summary>
			public const string ViewName = "msdyn_savedqueryname";

			/// <summary>msdyn_sortorder</summary>
			public const string SortOrder = "msdyn_sortorder";

			/// <summary>msdyn_type</summary>
			public const string Type = "msdyn_type";

			/// <summary>msdyn_userid</summary>
			public const string UserId = "msdyn_userid";

			/// <summary>msdyn_useridname</summary>
			public const string MsdynUseridname = "msdyn_useridname";

			/// <summary>msdyn_useridyominame</summary>
			public const string MsdynUseridyominame = "msdyn_useridyominame";

			/// <summary>msdyn_wallsavedqueryid</summary>
			public const string WallViewId = "msdyn_wallsavedqueryid";

			/// <summary>msdyn_wallsavedqueryidname</summary>
			public const string MsdynWallsavedqueryidname = "msdyn_wallsavedqueryidname";

			/// <summary>msdyn_wallsavedqueryusersettingsid</summary>
			public const string FilterId = "msdyn_wallsavedqueryusersettingsid";

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
			/// <summary>1:N msdyn_wallsavedqueryusersettings_AsyncOperations</summary>
			public const string MsdynWallsavedqueryusersettingsAsyncOperations = "msdyn_wallsavedqueryusersettings_AsyncOperations";

			/// <summary>1:N msdyn_wallsavedqueryusersettings_BulkDeleteFailures</summary>
			public const string MsdynWallsavedqueryusersettingsBulkDeleteFailures = "msdyn_wallsavedqueryusersettings_BulkDeleteFailures";

			/// <summary>1:N msdyn_wallsavedqueryusersettings_MailboxTrackingFolders</summary>
			public const string MsdynWallsavedqueryusersettingsMailboxTrackingFolders = "msdyn_wallsavedqueryusersettings_MailboxTrackingFolders";

			/// <summary>1:N msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses = "msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_wallsavedqueryusersettings_ProcessSession</summary>
			public const string MsdynWallsavedqueryusersettingsProcessSession = "msdyn_wallsavedqueryusersettings_ProcessSession";

			/// <summary>1:N msdyn_wallsavedqueryusersettings_SyncErrors</summary>
			public const string MsdynWallsavedqueryusersettingsSyncErrors = "msdyn_wallsavedqueryusersettings_SyncErrors";

		}
		#endregion
	}
}

