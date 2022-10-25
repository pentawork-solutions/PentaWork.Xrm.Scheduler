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
	[EntityLogicalName("msdyn_playbooktemplate")]
	public sealed class PlaybookTemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 10081;
		public new const string LogicalName = "msdyn_playbooktemplate";
		public const string PrimaryIdAttribute = "msdyn_playbooktemplateid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public PlaybookTemplate() : base("msdyn_playbooktemplate") { }

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
        /// msdyn_categoryid
        /// </summary>
		[DisplayName("Category")]
		[AttributeLogicalName("msdyn_categoryid")]
		public EntityReference Category
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_categoryid"); }
			set
			{ 
				if(value == Category) return;
				SetAttributeValue("msdyn_categoryid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_categoryidname
        /// </summary>
		[DisplayName("msdyn_categoryidname")]
		[AttributeLogicalName("msdyn_categoryidname")]
		public string MsdynCategoryidname
		{	
			get { return GetAttributeValue<string>("msdyn_categoryidname"); }
			set
			{ 
				if(value == MsdynCategoryidname) return;
				SetAttributeValue("msdyn_categoryidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("msdyn_description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_estimatedduration
        /// </summary>
		[DisplayName("Estimated duration (days)")]
		[AttributeLogicalName("msdyn_estimatedduration")]
		public int? EstimatedDurationdays
		{	
			get { return GetAttributeValue<int?>("msdyn_estimatedduration"); }
			set
			{ 
				if(value == EstimatedDurationdays) return;
				SetAttributeValue("msdyn_estimatedduration", value);
			}
		}	
			
		/// <summary>
        /// msdyn_fullentitylist
        /// </summary>
		[DisplayName("Entities enabled for playbook")]
		[AttributeLogicalName("msdyn_fullentitylist")]
		public string EntitiesEnabledForPlaybook
		{	
			get { return GetAttributeValue<string>("msdyn_fullentitylist"); }
			set
			{ 
				if(value == EntitiesEnabledForPlaybook) return;
				SetAttributeValue("msdyn_fullentitylist", value);
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
        /// msdyn_playbooktemplateid
        /// </summary>
		[DisplayName("Playbook template")]
		[AttributeLogicalName("msdyn_playbooktemplateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_playbooktemplateid", value); }
		}

							/// <summary>
        /// msdyn_relatedentitylist
        /// </summary>
		[DisplayName("Entities to which a playbook applies")]
		[AttributeLogicalName("msdyn_relatedentitylist")]
		public string EntitiesToWhichAPlaybookApplies
		{	
			get { return GetAttributeValue<string>("msdyn_relatedentitylist"); }
			set
			{ 
				if(value == EntitiesToWhichAPlaybookApplies) return;
				SetAttributeValue("msdyn_relatedentitylist", value);
			}
		}	
			
		/// <summary>
        /// msdyn_trackprogress
        /// </summary>
		[DisplayName("Track progress")]
		[AttributeLogicalName("msdyn_trackprogress")]
		public bool? TrackProgress
		{	
			get { return GetAttributeValue<bool?>("msdyn_trackprogress"); }
			set
			{ 
				if(value == TrackProgress) return;
				SetAttributeValue("msdyn_trackprogress", value);
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
		[DisplayName("Publisher")]
		[AttributeLogicalName("ownerid")]
		public EntityReference Publisher
		{	
			get { return GetAttributeValue<EntityReference>("ownerid"); }
			set
			{ 
				if(value == Publisher) return;
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
        /// 1:N Get entities for 'msdyn_playbooktemplate_Annotations'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_Annotations")]
		public IEnumerable<Note> MsdynPlaybooktemplateAnnotations
		{
			get { return GetRelatedEntities<Note>("msdyn_playbooktemplate_Annotations", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynPlaybooktemplateAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_playbooktemplate_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynPlaybooktemplateBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_playbooktemplate_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynPlaybooktemplateDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_playbooktemplate_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynPlaybooktemplateDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_playbooktemplate_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynPlaybooktemplateMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_playbooktemplate_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_msdyn_playbookactivity'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_msdyn_playbookactivity")]
		public IEnumerable<PlaybookActivity> MsdynPlaybooktemplateMsdynPlaybookactivity
		{
			get { return GetRelatedEntities<PlaybookActivity>("msdyn_playbooktemplate_msdyn_playbookactivity", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_msdyn_playbookactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_msdyn_playbookinstance'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_msdyn_playbookinstance")]
		public IEnumerable<Playbook> MsdynPlaybooktemplateMsdynPlaybookinstance
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbooktemplate_msdyn_playbookinstance", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_msdyn_playbookinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynPlaybooktemplatePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_playbooktemplate_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynPlaybooktemplateProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_playbooktemplate_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbooktemplate_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbooktemplate_SyncErrors")]
		public IEnumerable<SyncError> MsdynPlaybooktemplateSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_playbooktemplate_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_playbooktemplate_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'PlaybookCallableContext'
        /// </summary>
		[RelationshipSchemaName("msdyn_callablecontext_msdyn_playbooktemplate")]
		public IEnumerable<PlaybookCallableContext> MsdynCallablecontextMsdynPlaybooktemplate
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("msdyn_callablecontext_msdyn_playbooktemplate", null); }
			set { SetRelatedEntities("msdyn_callablecontext_msdyn_playbooktemplate", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 1, 
		
			[Label("Published")]
			[Description(@"")]
			Published_Inactive = 2, 
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

			/// <summary>msdyn_categoryid</summary>
			public const string Category = "msdyn_categoryid";

			/// <summary>msdyn_categoryidname</summary>
			public const string MsdynCategoryidname = "msdyn_categoryidname";

			/// <summary>msdyn_description</summary>
			public const string Description = "msdyn_description";

			/// <summary>msdyn_estimatedduration</summary>
			public const string EstimatedDurationdays = "msdyn_estimatedduration";

			/// <summary>msdyn_fullentitylist</summary>
			public const string EntitiesEnabledForPlaybook = "msdyn_fullentitylist";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_playbooktemplateid</summary>
			public const string PlaybookTemplateId = "msdyn_playbooktemplateid";

			/// <summary>msdyn_relatedentitylist</summary>
			public const string EntitiesToWhichAPlaybookApplies = "msdyn_relatedentitylist";

			/// <summary>msdyn_trackprogress</summary>
			public const string TrackProgress = "msdyn_trackprogress";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>ownerid</summary>
			public const string Publisher = "ownerid";

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
			/// <summary>1:N msdyn_playbooktemplate_Annotations</summary>
			public const string MsdynPlaybooktemplateAnnotations = "msdyn_playbooktemplate_Annotations";

			/// <summary>1:N msdyn_playbooktemplate_AsyncOperations</summary>
			public const string MsdynPlaybooktemplateAsyncOperations = "msdyn_playbooktemplate_AsyncOperations";

			/// <summary>1:N msdyn_playbooktemplate_BulkDeleteFailures</summary>
			public const string MsdynPlaybooktemplateBulkDeleteFailures = "msdyn_playbooktemplate_BulkDeleteFailures";

			/// <summary>1:N msdyn_playbooktemplate_DuplicateBaseRecord</summary>
			public const string MsdynPlaybooktemplateDuplicateBaseRecord = "msdyn_playbooktemplate_DuplicateBaseRecord";

			/// <summary>1:N msdyn_playbooktemplate_DuplicateMatchingRecord</summary>
			public const string MsdynPlaybooktemplateDuplicateMatchingRecord = "msdyn_playbooktemplate_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_playbooktemplate_MailboxTrackingFolders</summary>
			public const string MsdynPlaybooktemplateMailboxTrackingFolders = "msdyn_playbooktemplate_MailboxTrackingFolders";

			/// <summary>1:N msdyn_playbooktemplate_msdyn_playbookactivity</summary>
			public const string MsdynPlaybooktemplateMsdynPlaybookactivity = "msdyn_playbooktemplate_msdyn_playbookactivity";

			/// <summary>1:N msdyn_playbooktemplate_msdyn_playbookinstance</summary>
			public const string MsdynPlaybooktemplateMsdynPlaybookinstance = "msdyn_playbooktemplate_msdyn_playbookinstance";

			/// <summary>1:N msdyn_playbooktemplate_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynPlaybooktemplatePrincipalObjectAttributeAccesses = "msdyn_playbooktemplate_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_playbooktemplate_ProcessSession</summary>
			public const string MsdynPlaybooktemplateProcessSession = "msdyn_playbooktemplate_ProcessSession";

			/// <summary>1:N msdyn_playbooktemplate_SyncErrors</summary>
			public const string MsdynPlaybooktemplateSyncErrors = "msdyn_playbooktemplate_SyncErrors";

			/// <summary>N:N msdyn_callablecontext_msdyn_playbooktemplate</summary>
			public const string MsdynCallablecontextMsdynPlaybooktemplate = "msdyn_callablecontext_msdyn_playbooktemplate";

		}
		#endregion
	}
}

