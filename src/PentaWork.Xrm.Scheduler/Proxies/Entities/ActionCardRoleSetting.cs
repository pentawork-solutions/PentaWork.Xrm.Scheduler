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
	[EntityLogicalName("msdyn_actioncardrolesetting")]
	public sealed class ActionCardRoleSetting : Entity
	{	
		public static readonly int? EntityTypeCode = 10088;
		public new const string LogicalName = "msdyn_actioncardrolesetting";
		public const string PrimaryIdAttribute = "msdyn_actioncardrolesettingid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public ActionCardRoleSetting() : base("msdyn_actioncardrolesetting") { }

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
        /// msdyn_actioncardrolesettingid
        /// </summary>
		[DisplayName("Action Card Role Setting")]
		[AttributeLogicalName("msdyn_actioncardrolesettingid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_actioncardrolesettingid", value); }
		}

							/// <summary>
        /// msdyn_cardtypeid
        /// </summary>
		[DisplayName("cardtypeid")]
		[AttributeLogicalName("msdyn_cardtypeid")]
		public EntityReference Cardtypeid
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_cardtypeid"); }
			set
			{ 
				if(value == Cardtypeid) return;
				SetAttributeValue("msdyn_cardtypeid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_cardtypeidname
        /// </summary>
		[DisplayName("msdyn_cardtypeidname")]
		[AttributeLogicalName("msdyn_cardtypeidname")]
		public string MsdynCardtypeidname
		{	
			get { return GetAttributeValue<string>("msdyn_cardtypeidname"); }
			set
			{ 
				if(value == MsdynCardtypeidname) return;
				SetAttributeValue("msdyn_cardtypeidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isdisabled
        /// </summary>
		[DisplayName("Is Disabled")]
		[AttributeLogicalName("msdyn_isdisabled")]
		public bool? IsDisabled
		{	
			get { return GetAttributeValue<bool?>("msdyn_isdisabled"); }
			set
			{ 
				if(value == IsDisabled) return;
				SetAttributeValue("msdyn_isdisabled", value);
			}
		}	
			
		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_roleid
        /// </summary>
		[DisplayName("RoleId")]
		[AttributeLogicalName("msdyn_roleid")]
		public EntityReference RoleId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_roleid"); }
			set
			{ 
				if(value == RoleId) return;
				SetAttributeValue("msdyn_roleid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_roleidname
        /// </summary>
		[DisplayName("msdyn_roleidname")]
		[AttributeLogicalName("msdyn_roleidname")]
		public string MsdynRoleidname
		{	
			get { return GetAttributeValue<string>("msdyn_roleidname"); }
			set
			{ 
				if(value == MsdynRoleidname) return;
				SetAttributeValue("msdyn_roleidname", value);
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
        /// 1:N Get entities for 'msdyn_actioncardrolesetting_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_actioncardrolesetting_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynActioncardrolesettingAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_actioncardrolesetting_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_actioncardrolesetting_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_actioncardrolesetting_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_actioncardrolesetting_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynActioncardrolesettingBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_actioncardrolesetting_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_actioncardrolesetting_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_actioncardrolesetting_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_actioncardrolesetting_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynActioncardrolesettingMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_actioncardrolesetting_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_actioncardrolesetting_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynActioncardrolesettingPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_actioncardrolesetting_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_actioncardrolesetting_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynActioncardrolesettingProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_actioncardrolesetting_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_actioncardrolesetting_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_actioncardrolesetting_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_actioncardrolesetting_SyncErrors")]
		public IEnumerable<SyncError> MsdynActioncardrolesettingSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_actioncardrolesetting_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_actioncardrolesetting_SyncErrors", null, value); }
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

			/// <summary>msdyn_actioncardrolesettingid</summary>
			public const string ActionCardRoleSettingId = "msdyn_actioncardrolesettingid";

			/// <summary>msdyn_cardtypeid</summary>
			public const string Cardtypeid = "msdyn_cardtypeid";

			/// <summary>msdyn_cardtypeidname</summary>
			public const string MsdynCardtypeidname = "msdyn_cardtypeidname";

			/// <summary>msdyn_isdisabled</summary>
			public const string IsDisabled = "msdyn_isdisabled";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_roleid</summary>
			public const string RoleId = "msdyn_roleid";

			/// <summary>msdyn_roleidname</summary>
			public const string MsdynRoleidname = "msdyn_roleidname";

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
			/// <summary>1:N msdyn_actioncardrolesetting_AsyncOperations</summary>
			public const string MsdynActioncardrolesettingAsyncOperations = "msdyn_actioncardrolesetting_AsyncOperations";

			/// <summary>1:N msdyn_actioncardrolesetting_BulkDeleteFailures</summary>
			public const string MsdynActioncardrolesettingBulkDeleteFailures = "msdyn_actioncardrolesetting_BulkDeleteFailures";

			/// <summary>1:N msdyn_actioncardrolesetting_MailboxTrackingFolders</summary>
			public const string MsdynActioncardrolesettingMailboxTrackingFolders = "msdyn_actioncardrolesetting_MailboxTrackingFolders";

			/// <summary>1:N msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynActioncardrolesettingPrincipalObjectAttributeAccesses = "msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_actioncardrolesetting_ProcessSession</summary>
			public const string MsdynActioncardrolesettingProcessSession = "msdyn_actioncardrolesetting_ProcessSession";

			/// <summary>1:N msdyn_actioncardrolesetting_SyncErrors</summary>
			public const string MsdynActioncardrolesettingSyncErrors = "msdyn_actioncardrolesetting_SyncErrors";

		}
		#endregion
	}
}

