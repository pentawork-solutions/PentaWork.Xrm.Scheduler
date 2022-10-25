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
	[EntityLogicalName("slaitem")]
	public sealed class SLAItem : Entity
	{	
		public static readonly int? EntityTypeCode = 9751;
		public new const string LogicalName = "slaitem";
		public const string PrimaryIdAttribute = "slaitemid";
		public const string PrimaryNameAttribute = "name";
	
		public SLAItem() : base("slaitem") { }

		#region Attributes
		/// <summary>
        /// actionflowuniquename
        /// </summary>
		[DisplayName("Action Flow Unique Name")]
		[AttributeLogicalName("actionflowuniquename")]
		public string ActionFlowUniqueName
		{	
			get { return GetAttributeValue<string>("actionflowuniquename"); }
			set
			{ 
				if(value == ActionFlowUniqueName) return;
				SetAttributeValue("actionflowuniquename", value);
			}
		}	
			
		/// <summary>
        /// actionurl
        /// </summary>
		[DisplayName("Action URL")]
		[AttributeLogicalName("actionurl")]
		public string ActionURL
		{	
			get { return GetAttributeValue<string>("actionurl"); }
			set
			{ 
				if(value == ActionURL) return;
				SetAttributeValue("actionurl", value);
			}
		}	
			
		/// <summary>
        /// allowpauseresume
        /// </summary>
		[DisplayName("Allow Pause and Resume")]
		[AttributeLogicalName("allowpauseresume")]
		public bool? AllowPauseAndResume
		{	
			get { return GetAttributeValue<bool?>("allowpauseresume"); }
			set
			{ 
				if(value == AllowPauseAndResume) return;
				SetAttributeValue("allowpauseresume", value);
			}
		}	
			
		/// <summary>
        /// applicableentity
        /// </summary>
		[DisplayName("Applicable Entity")]
		[AttributeLogicalName("applicableentity")]
		public string ApplicableEntity
		{	
			get { return GetAttributeValue<string>("applicableentity"); }
			set
			{ 
				if(value == ApplicableEntity) return;
				SetAttributeValue("applicableentity", value);
			}
		}	
			
		/// <summary>
        /// applicablewhenxml
        /// </summary>
		[DisplayName("ApplicableWhenXml")]
		[AttributeLogicalName("applicablewhenxml")]
		public string ApplicableWhenXml
		{	
			get { return GetAttributeValue<string>("applicablewhenxml"); }
			set
			{ 
				if(value == ApplicableWhenXml) return;
				SetAttributeValue("applicablewhenxml", value);
			}
		}	
			
		/// <summary>
        /// businesshoursid
        /// </summary>
		[DisplayName("Business Hours")]
		[AttributeLogicalName("businesshoursid")]
		public EntityReference BusinessHours
		{	
			get { return GetAttributeValue<EntityReference>("businesshoursid"); }
			set
			{ 
				if(value == BusinessHours) return;
				SetAttributeValue("businesshoursid", value);
			}
		}	
			
		/// <summary>
        /// businesshoursidname
        /// </summary>
		[DisplayName("businesshoursidname")]
		[AttributeLogicalName("businesshoursidname")]
		public string Businesshoursidname
		{	
			get { return GetAttributeValue<string>("businesshoursidname"); }
			set
			{ 
				if(value == Businesshoursidname) return;
				SetAttributeValue("businesshoursidname", value);
			}
		}	
			
		/// <summary>
        /// changedattributelist
        /// </summary>
		[DisplayName("Changed Attribute List")]
		[AttributeLogicalName("changedattributelist")]
		public string ChangedAttributeList
		{	
			get { return GetAttributeValue<string>("changedattributelist"); }
			set
			{ 
				if(value == ChangedAttributeList) return;
				SetAttributeValue("changedattributelist", value);
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
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
			}
		}	
			
		/// <summary>
        /// failureafter
        /// </summary>
		[DisplayName("Failure After")]
		[AttributeLogicalName("failureafter")]
		public int? FailureAfter
		{	
			get { return GetAttributeValue<int?>("failureafter"); }
			set
			{ 
				if(value == FailureAfter) return;
				SetAttributeValue("failureafter", value);
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
        /// relatedfield
        /// </summary>
		[DisplayName("Related Case Field")]
		[AttributeLogicalName("relatedfield")]
		public string RelatedCaseField
		{	
			get { return GetAttributeValue<string>("relatedfield"); }
			set
			{ 
				if(value == RelatedCaseField) return;
				SetAttributeValue("relatedfield", value);
			}
		}	
			
		/// <summary>
        /// sequencenumber
        /// </summary>
		[DisplayName("Sequence")]
		[AttributeLogicalName("sequencenumber")]
		public int? Sequence
		{	
			get { return GetAttributeValue<int?>("sequencenumber"); }
			set
			{ 
				if(value == Sequence) return;
				SetAttributeValue("sequencenumber", value);
			}
		}	
			
		/// <summary>
        /// slaid
        /// </summary>
		[DisplayName("SLA")]
		[AttributeLogicalName("slaid")]
		public EntityReference SLA
		{	
			get { return GetAttributeValue<EntityReference>("slaid"); }
			set
			{ 
				if(value == SLA) return;
				SetAttributeValue("slaid", value);
			}
		}	
			
		/// <summary>
        /// slaidname
        /// </summary>
		[DisplayName("slaidname")]
		[AttributeLogicalName("slaidname")]
		public string Slaidname
		{	
			get { return GetAttributeValue<string>("slaidname"); }
			set
			{ 
				if(value == Slaidname) return;
				SetAttributeValue("slaidname", value);
			}
		}	
			
		/// <summary>
        /// slaitemid
        /// </summary>
		[DisplayName("SLA Item")]
		[AttributeLogicalName("slaitemid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("slaitemid", value); }
		}

							/// <summary>
        /// slaitemidunique
        /// </summary>
		[DisplayName("Unique Id")]
		[AttributeLogicalName("slaitemidunique")]
		public Guid UniqueId
		{	
			get { return GetAttributeValue<Guid>("slaitemidunique"); }
			set
			{ 
				if(value == UniqueId) return;
				SetAttributeValue("slaitemidunique", value);
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
        /// successconditionsxml
        /// </summary>
		[DisplayName("SuccessConditionsXml")]
		[AttributeLogicalName("successconditionsxml")]
		public string SuccessConditionsXml
		{	
			get { return GetAttributeValue<string>("successconditionsxml"); }
			set
			{ 
				if(value == SuccessConditionsXml) return;
				SetAttributeValue("successconditionsxml", value);
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
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
			
		/// <summary>
        /// warnafter
        /// </summary>
		[DisplayName("Warn After")]
		[AttributeLogicalName("warnafter")]
		public int? WarnAfter
		{	
			get { return GetAttributeValue<int?>("warnafter"); }
			set
			{ 
				if(value == WarnAfter) return;
				SetAttributeValue("warnafter", value);
			}
		}	
			
		/// <summary>
        /// workflowid
        /// </summary>
		[DisplayName("Workflow ID")]
		[AttributeLogicalName("workflowid")]
		public EntityReference WorkflowID
		{	
			get { return GetAttributeValue<EntityReference>("workflowid"); }
			set
			{ 
				if(value == WorkflowID) return;
				SetAttributeValue("workflowid", value);
			}
		}	
			
		/// <summary>
        /// workflowidname
        /// </summary>
		[DisplayName("workflowidname")]
		[AttributeLogicalName("workflowidname")]
		public string Workflowidname
		{	
			get { return GetAttributeValue<string>("workflowidname"); }
			set
			{ 
				if(value == Workflowidname) return;
				SetAttributeValue("workflowidname", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'SLAItem_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SLAItem_SyncErrors")]
		public IEnumerable<SyncError> SLAItemSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SLAItem_SyncErrors", null); }
			set { SetRelatedEntities("SLAItem_SyncErrors", null, value); }
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
			/// <summary>actionflowuniquename</summary>
			public const string ActionFlowUniqueName = "actionflowuniquename";

			/// <summary>actionurl</summary>
			public const string ActionURL = "actionurl";

			/// <summary>allowpauseresume</summary>
			public const string AllowPauseAndResume = "allowpauseresume";

			/// <summary>applicableentity</summary>
			public const string ApplicableEntity = "applicableentity";

			/// <summary>applicablewhenxml</summary>
			public const string ApplicableWhenXml = "applicablewhenxml";

			/// <summary>businesshoursid</summary>
			public const string BusinessHours = "businesshoursid";

			/// <summary>businesshoursidname</summary>
			public const string Businesshoursidname = "businesshoursidname";

			/// <summary>changedattributelist</summary>
			public const string ChangedAttributeList = "changedattributelist";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>failureafter</summary>
			public const string FailureAfter = "failureafter";

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

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>relatedfield</summary>
			public const string RelatedCaseField = "relatedfield";

			/// <summary>sequencenumber</summary>
			public const string Sequence = "sequencenumber";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slaidname</summary>
			public const string Slaidname = "slaidname";

			/// <summary>slaitemid</summary>
			public const string SLAItemId = "slaitemid";

			/// <summary>slaitemidunique</summary>
			public const string UniqueId = "slaitemidunique";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>successconditionsxml</summary>
			public const string SuccessConditionsXml = "successconditionsxml";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>warnafter</summary>
			public const string WarnAfter = "warnafter";

			/// <summary>workflowid</summary>
			public const string WorkflowID = "workflowid";

			/// <summary>workflowidname</summary>
			public const string Workflowidname = "workflowidname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N SLAItem_SyncErrors</summary>
			public const string SLAItemSyncErrors = "SLAItem_SyncErrors";

		}
		#endregion
	}
}

