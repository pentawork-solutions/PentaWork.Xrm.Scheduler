using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("processtrigger")]
	public sealed class ProcessTrigger : Entity
	{	
		public static readonly int? EntityTypeCode = 4712;
		public new const string LogicalName = "processtrigger";
		public const string PrimaryIdAttribute = "processtriggerid";
		public const string PrimaryNameAttribute = "";
	
		public ProcessTrigger() : base("processtrigger") { }

		#region Attributes
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
        /// controlname
        /// </summary>
		[DisplayName("Control Name")]
		[AttributeLogicalName("controlname")]
		public string ControlName
		{	
			get { return GetAttributeValue<string>("controlname"); }
			set
			{ 
				if(value == ControlName) return;
				SetAttributeValue("controlname", value);
			}
		}	
			
		/// <summary>
        /// controltype
        /// </summary>
		[DisplayName("Control Type")]
		[AttributeLogicalName("controltype")]
		public eControlType? ControlType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("controltype");
				if (optionSetValue != null) return (eControlType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ControlType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("controltype", optionSetValue); 
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
        /// event
        /// </summary>
		[DisplayName("Event")]
		[AttributeLogicalName("event")]
		public string Event
		{	
			get { return GetAttributeValue<string>("event"); }
			set
			{ 
				if(value == Event) return;
				SetAttributeValue("event", value);
			}
		}	
			
		/// <summary>
        /// formid
        /// </summary>
		[DisplayName("Form")]
		[AttributeLogicalName("formid")]
		public EntityReference Form
		{	
			get { return GetAttributeValue<EntityReference>("formid"); }
			set
			{ 
				if(value == Form) return;
				SetAttributeValue("formid", value);
			}
		}	
			
		/// <summary>
        /// formidname
        /// </summary>
		[DisplayName("Form Name")]
		[AttributeLogicalName("formidname")]
		public string FormName
		{	
			get { return GetAttributeValue<string>("formidname"); }
			set
			{ 
				if(value == FormName) return;
				SetAttributeValue("formidname", value);
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
        /// methodid
        /// </summary>
		[DisplayName("MethodId")]
		[AttributeLogicalName("methodid")]
		public Guid MethodId
		{	
			get { return GetAttributeValue<Guid>("methodid"); }
			set
			{ 
				if(value == MethodId) return;
				SetAttributeValue("methodid", value);
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
		public Guid OwningBusinessUnitId
		{	
			get { return GetAttributeValue<Guid>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnitId) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("Owning User")]
		[AttributeLogicalName("owninguser")]
		public Guid OwningUserId
		{	
			get { return GetAttributeValue<Guid>("owninguser"); }
			set
			{ 
				if(value == OwningUserId) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// pipelinestage
        /// </summary>
		[DisplayName("PipelineStage")]
		[AttributeLogicalName("pipelinestage")]
		public eProcesstriggerPipelinestage? PipelineStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("pipelinestage");
				if (optionSetValue != null) return (eProcesstriggerPipelinestage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PipelineStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("pipelinestage", optionSetValue); 
			}
		}

		/// <summary>
        /// primaryentitytypecode
        /// </summary>
		[DisplayName("Primary Entity")]
		[AttributeLogicalName("primaryentitytypecode")]
		public string PrimaryEntity
		{	
			get { return GetAttributeValue<string>("primaryentitytypecode"); }
			set
			{ 
				if(value == PrimaryEntity) return;
				SetAttributeValue("primaryentitytypecode", value);
			}
		}	
			
		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("processid")]
		public EntityReference Process
		{	
			get { return GetAttributeValue<EntityReference>("processid"); }
			set
			{ 
				if(value == Process) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// processidname
        /// </summary>
		[DisplayName("processidname")]
		[AttributeLogicalName("processidname")]
		public string Processidname
		{	
			get { return GetAttributeValue<string>("processidname"); }
			set
			{ 
				if(value == Processidname) return;
				SetAttributeValue("processidname", value);
			}
		}	
			
		/// <summary>
        /// processtriggerid
        /// </summary>
		[DisplayName("Process Trigger")]
		[AttributeLogicalName("processtriggerid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("processtriggerid", value); }
		}

							/// <summary>
        /// processtriggeridunique
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("processtriggeridunique")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processtriggeridunique"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processtriggeridunique", value);
			}
		}	
			
		/// <summary>
        /// scope
        /// </summary>
		[DisplayName("Scope")]
		[AttributeLogicalName("scope")]
		public ePblScope? Scope
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("scope");
				if (optionSetValue != null) return (ePblScope)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Scope) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("scope", optionSetValue); 
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
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ProcessTrigger_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ProcessTrigger_SyncErrors")]
		public IEnumerable<SyncError> ProcessTriggerSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ProcessTrigger_SyncErrors", null); }
			set { SetRelatedEntities("ProcessTrigger_SyncErrors", null, value); }
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
		
		public enum ePblScope
		{	
		
			[Label("Form")]
			[Description(@"")]
			Form = 1, 
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 2, 
		}
		
		public enum eControlType
		{	
		
			[Label("Attribute")]
			[Description(@"")]
			Attribute = 1, 
		
			[Label("Form Tab")]
			[Description(@"")]
			FormTab = 2, 
		}
		
		public enum eProcesstriggerPipelinestage
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 0, 
		
			[Label("Before Main Operation")]
			[Description(@"")]
			BeforeMainOperation = 20, 
		
			[Label("After Main Operation")]
			[Description(@"")]
			AfterMainOperation = 40, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>controlname</summary>
			public const string ControlName = "controlname";

			/// <summary>controltype</summary>
			public const string ControlType = "controltype";

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

			/// <summary>event</summary>
			public const string Event = "event";

			/// <summary>formid</summary>
			public const string Form = "formid";

			/// <summary>formidname</summary>
			public const string FormName = "formidname";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>methodid</summary>
			public const string MethodId = "methodid";

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

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnitId = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwningUserId = "owninguser";

			/// <summary>pipelinestage</summary>
			public const string PipelineStage = "pipelinestage";

			/// <summary>primaryentitytypecode</summary>
			public const string PrimaryEntity = "primaryentitytypecode";

			/// <summary>processid</summary>
			public const string Process = "processid";

			/// <summary>processidname</summary>
			public const string Processidname = "processidname";

			/// <summary>processtriggerid</summary>
			public const string ProcessTriggerId = "processtriggerid";

			/// <summary>processtriggeridunique</summary>
			public const string ProcessId = "processtriggeridunique";

			/// <summary>scope</summary>
			public const string Scope = "scope";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ProcessTrigger_SyncErrors</summary>
			public const string ProcessTriggerSyncErrors = "ProcessTrigger_SyncErrors";

		}
		#endregion
	}
}

