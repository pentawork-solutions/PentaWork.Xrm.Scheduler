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
	[EntityLogicalName("goalrollupquery")]
	public sealed class RollupQuery : Entity
	{	
		public static readonly int? EntityTypeCode = 9602;
		public new const string LogicalName = "goalrollupquery";
		public const string PrimaryIdAttribute = "goalrollupqueryid";
		public const string PrimaryNameAttribute = "name";
	
		public RollupQuery() : base("goalrollupquery") { }

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
        /// fetchxml
        /// </summary>
		[DisplayName("Condition Criteria")]
		[AttributeLogicalName("fetchxml")]
		public string ConditionCriteria
		{	
			get { return GetAttributeValue<string>("fetchxml"); }
			set
			{ 
				if(value == ConditionCriteria) return;
				SetAttributeValue("fetchxml", value);
			}
		}	
			
		/// <summary>
        /// goalrollupqueryid
        /// </summary>
		[DisplayName("Goal Rollup Query")]
		[AttributeLogicalName("goalrollupqueryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("goalrollupqueryid", value); }
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
        /// queryentitytype
        /// </summary>
		[DisplayName("Entity Type")]
		[AttributeLogicalName("queryentitytype")]
		public string EntityType
		{	
			get { return GetAttributeValue<string>("queryentitytype"); }
			set
			{ 
				if(value == EntityType) return;
				SetAttributeValue("queryentitytype", value);
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
        /// 1:N Get entities for 'goal_rollupquery_actualdecimal'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_actualdecimal")]
		public IEnumerable<Goal> GoalRollupqueryActualdecimal
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_actualdecimal", null); }
			set { SetRelatedEntities("goal_rollupquery_actualdecimal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_actualmoney'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_actualmoney")]
		public IEnumerable<Goal> GoalRollupqueryActualmoney
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_actualmoney", null); }
			set { SetRelatedEntities("goal_rollupquery_actualmoney", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_customdecimal'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_customdecimal")]
		public IEnumerable<Goal> GoalRollupqueryCustomdecimal
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_customdecimal", null); }
			set { SetRelatedEntities("goal_rollupquery_customdecimal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_customint'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_customint")]
		public IEnumerable<Goal> GoalRollupqueryCustomint
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_customint", null); }
			set { SetRelatedEntities("goal_rollupquery_customint", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_custommoney'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_custommoney")]
		public IEnumerable<Goal> GoalRollupqueryCustommoney
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_custommoney", null); }
			set { SetRelatedEntities("goal_rollupquery_custommoney", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_inprogressdecimal'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_inprogressdecimal")]
		public IEnumerable<Goal> GoalRollupqueryInprogressdecimal
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_inprogressdecimal", null); }
			set { SetRelatedEntities("goal_rollupquery_inprogressdecimal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_inprogressint'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_inprogressint")]
		public IEnumerable<Goal> GoalRollupqueryInprogressint
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_inprogressint", null); }
			set { SetRelatedEntities("goal_rollupquery_inprogressint", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_rollupquery_inprogressmoney'
        /// </summary>
		[RelationshipSchemaName("goal_rollupquery_inprogressmoney")]
		public IEnumerable<Goal> GoalRollupqueryInprogressmoney
		{
			get { return GetRelatedEntities<Goal>("goal_rollupquery_inprogressmoney", null); }
			set { SetRelatedEntities("goal_rollupquery_inprogressmoney", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goalrollupquery_actualint'
        /// </summary>
		[RelationshipSchemaName("goalrollupquery_actualint")]
		public IEnumerable<Goal> GoalrollupqueryActualint
		{
			get { return GetRelatedEntities<Goal>("goalrollupquery_actualint", null); }
			set { SetRelatedEntities("goalrollupquery_actualint", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goalrollupquery_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("goalrollupquery_AsyncOperations")]
		public IEnumerable<SystemJob> GoalrollupqueryAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("goalrollupquery_AsyncOperations", null); }
			set { SetRelatedEntities("goalrollupquery_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'GoalRollupQuery_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("GoalRollupQuery_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> GoalRollupQueryDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("GoalRollupQuery_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("GoalRollupQuery_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'GoalRollupQuery_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("GoalRollupQuery_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> GoalRollupQueryDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("GoalRollupQuery_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("GoalRollupQuery_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goalrollupquery_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("goalrollupquery_ProcessSessions")]
		public IEnumerable<ProcessSession> GoalrollupqueryProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("goalrollupquery_ProcessSessions", null); }
			set { SetRelatedEntities("goalrollupquery_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'GoalRollupQuery_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("GoalRollupQuery_SyncErrors")]
		public IEnumerable<SyncError> GoalRollupQuerySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("GoalRollupQuery_SyncErrors", null); }
			set { SetRelatedEntities("GoalRollupQuery_SyncErrors", null, value); }
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
		
			[Label("Open")]
			[Description(@"")]
			Open_Active = 0, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed_Inactive = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>fetchxml</summary>
			public const string ConditionCriteria = "fetchxml";

			/// <summary>goalrollupqueryid</summary>
			public const string GoalRollupQueryId = "goalrollupqueryid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

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

			/// <summary>queryentitytype</summary>
			public const string EntityType = "queryentitytype";

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
			/// <summary>1:N goal_rollupquery_actualdecimal</summary>
			public const string GoalRollupqueryActualdecimal = "goal_rollupquery_actualdecimal";

			/// <summary>1:N goal_rollupquery_actualmoney</summary>
			public const string GoalRollupqueryActualmoney = "goal_rollupquery_actualmoney";

			/// <summary>1:N goal_rollupquery_customdecimal</summary>
			public const string GoalRollupqueryCustomdecimal = "goal_rollupquery_customdecimal";

			/// <summary>1:N goal_rollupquery_customint</summary>
			public const string GoalRollupqueryCustomint = "goal_rollupquery_customint";

			/// <summary>1:N goal_rollupquery_custommoney</summary>
			public const string GoalRollupqueryCustommoney = "goal_rollupquery_custommoney";

			/// <summary>1:N goal_rollupquery_inprogressdecimal</summary>
			public const string GoalRollupqueryInprogressdecimal = "goal_rollupquery_inprogressdecimal";

			/// <summary>1:N goal_rollupquery_inprogressint</summary>
			public const string GoalRollupqueryInprogressint = "goal_rollupquery_inprogressint";

			/// <summary>1:N goal_rollupquery_inprogressmoney</summary>
			public const string GoalRollupqueryInprogressmoney = "goal_rollupquery_inprogressmoney";

			/// <summary>1:N goalrollupquery_actualint</summary>
			public const string GoalrollupqueryActualint = "goalrollupquery_actualint";

			/// <summary>1:N goalrollupquery_AsyncOperations</summary>
			public const string GoalrollupqueryAsyncOperations = "goalrollupquery_AsyncOperations";

			/// <summary>1:N GoalRollupQuery_DuplicateBaseRecord</summary>
			public const string GoalRollupQueryDuplicateBaseRecord = "GoalRollupQuery_DuplicateBaseRecord";

			/// <summary>1:N GoalRollupQuery_DuplicateMatchingRecord</summary>
			public const string GoalRollupQueryDuplicateMatchingRecord = "GoalRollupQuery_DuplicateMatchingRecord";

			/// <summary>1:N goalrollupquery_ProcessSessions</summary>
			public const string GoalrollupqueryProcessSessions = "goalrollupquery_ProcessSessions";

			/// <summary>1:N GoalRollupQuery_SyncErrors</summary>
			public const string GoalRollupQuerySyncErrors = "GoalRollupQuery_SyncErrors";

		}
		#endregion
	}
}

