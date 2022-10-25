using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("rollupfield")]
	public sealed class RollupField : Entity
	{	
		public static readonly int? EntityTypeCode = 9604;
		public new const string LogicalName = "rollupfield";
		public const string PrimaryIdAttribute = "rollupfieldid";
		public const string PrimaryNameAttribute = "";
	
		public RollupField() : base("rollupfield") { }

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
        /// dateattribute
        /// </summary>
		[DisplayName("Date Field")]
		[AttributeLogicalName("dateattribute")]
		public string DateField
		{	
			get { return GetAttributeValue<string>("dateattribute"); }
			set
			{ 
				if(value == DateField) return;
				SetAttributeValue("dateattribute", value);
			}
		}	
			
		/// <summary>
        /// entityfordateattribute
        /// </summary>
		[DisplayName("Record Type")]
		[AttributeLogicalName("entityfordateattribute")]
		public string RecordType
		{	
			get { return GetAttributeValue<string>("entityfordateattribute"); }
			set
			{ 
				if(value == RecordType) return;
				SetAttributeValue("entityfordateattribute", value);
			}
		}	
			
		/// <summary>
        /// goalattribute
        /// </summary>
		[DisplayName("Rollup Field")]
		[AttributeLogicalName("goalattribute")]
		public string RollupField2
		{	
			get { return GetAttributeValue<string>("goalattribute"); }
			set
			{ 
				if(value == RollupField2) return;
				SetAttributeValue("goalattribute", value);
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
        /// isstateparententityattribute
        /// </summary>
		[DisplayName("Is State/Status From Parent Entity")]
		[AttributeLogicalName("isstateparententityattribute")]
		public bool? IsStateStatusFromParentEntity
		{	
			get { return GetAttributeValue<bool?>("isstateparententityattribute"); }
			set
			{ 
				if(value == IsStateStatusFromParentEntity) return;
				SetAttributeValue("isstateparententityattribute", value);
			}
		}	
			
		/// <summary>
        /// metricid
        /// </summary>
		[DisplayName("Goal Metric")]
		[AttributeLogicalName("metricid")]
		public EntityReference GoalMetric
		{	
			get { return GetAttributeValue<EntityReference>("metricid"); }
			set
			{ 
				if(value == GoalMetric) return;
				SetAttributeValue("metricid", value);
			}
		}	
			
		/// <summary>
        /// metricidname
        /// </summary>
		[DisplayName("metricidname")]
		[AttributeLogicalName("metricidname")]
		public string Metricidname
		{	
			get { return GetAttributeValue<string>("metricidname"); }
			set
			{ 
				if(value == Metricidname) return;
				SetAttributeValue("metricidname", value);
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
        /// rollupfieldid
        /// </summary>
		[DisplayName("Rollup Field")]
		[AttributeLogicalName("rollupfieldid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("rollupfieldid", value); }
		}

							/// <summary>
        /// sourceattribute
        /// </summary>
		[DisplayName("Source Field")]
		[AttributeLogicalName("sourceattribute")]
		public string SourceField
		{	
			get { return GetAttributeValue<string>("sourceattribute"); }
			set
			{ 
				if(value == SourceField) return;
				SetAttributeValue("sourceattribute", value);
			}
		}	
			
		/// <summary>
        /// sourceentity
        /// </summary>
		[DisplayName("Source Record Type")]
		[AttributeLogicalName("sourceentity")]
		public string SourceRecordType
		{	
			get { return GetAttributeValue<string>("sourceentity"); }
			set
			{ 
				if(value == SourceRecordType) return;
				SetAttributeValue("sourceentity", value);
			}
		}	
			
		/// <summary>
        /// sourcestate
        /// </summary>
		[DisplayName("Source Record Type State")]
		[AttributeLogicalName("sourcestate")]
		public int? SourceRecordTypeState
		{	
			get { return GetAttributeValue<int?>("sourcestate"); }
			set
			{ 
				if(value == SourceRecordTypeState) return;
				SetAttributeValue("sourcestate", value);
			}
		}	
			
		/// <summary>
        /// sourcestatus
        /// </summary>
		[DisplayName("Source Record Type Status")]
		[AttributeLogicalName("sourcestatus")]
		public int? SourceRecordTypeStatus
		{	
			get { return GetAttributeValue<int?>("sourcestatus"); }
			set
			{ 
				if(value == SourceRecordTypeStatus) return;
				SetAttributeValue("sourcestatus", value);
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
        /// 1:N Get entities for 'rollupfield_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("rollupfield_AsyncOperations")]
		public IEnumerable<SystemJob> RollupfieldAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("rollupfield_AsyncOperations", null); }
			set { SetRelatedEntities("rollupfield_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'rollupfield_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("rollupfield_ProcessSessions")]
		public IEnumerable<ProcessSession> RollupfieldProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("rollupfield_ProcessSessions", null); }
			set { SetRelatedEntities("rollupfield_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RollupField_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("RollupField_SyncErrors")]
		public IEnumerable<SyncError> RollupFieldSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("RollupField_SyncErrors", null); }
			set { SetRelatedEntities("RollupField_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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

			/// <summary>dateattribute</summary>
			public const string DateField = "dateattribute";

			/// <summary>entityfordateattribute</summary>
			public const string RecordType = "entityfordateattribute";

			/// <summary>goalattribute</summary>
			public const string RollupField2 = "goalattribute";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isstateparententityattribute</summary>
			public const string IsStateStatusFromParentEntity = "isstateparententityattribute";

			/// <summary>metricid</summary>
			public const string GoalMetric = "metricid";

			/// <summary>metricidname</summary>
			public const string Metricidname = "metricidname";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>rollupfieldid</summary>
			public const string RollupFieldId = "rollupfieldid";

			/// <summary>sourceattribute</summary>
			public const string SourceField = "sourceattribute";

			/// <summary>sourceentity</summary>
			public const string SourceRecordType = "sourceentity";

			/// <summary>sourcestate</summary>
			public const string SourceRecordTypeState = "sourcestate";

			/// <summary>sourcestatus</summary>
			public const string SourceRecordTypeStatus = "sourcestatus";

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
			/// <summary>1:N rollupfield_AsyncOperations</summary>
			public const string RollupfieldAsyncOperations = "rollupfield_AsyncOperations";

			/// <summary>1:N rollupfield_ProcessSessions</summary>
			public const string RollupfieldProcessSessions = "rollupfield_ProcessSessions";

			/// <summary>1:N RollupField_SyncErrors</summary>
			public const string RollupFieldSyncErrors = "RollupField_SyncErrors";

		}
		#endregion
	}
}

