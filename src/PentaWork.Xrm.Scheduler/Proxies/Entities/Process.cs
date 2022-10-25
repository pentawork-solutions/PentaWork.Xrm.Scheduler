using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ProcessName}")] 	
	[EntityLogicalName("workflow")]
	public sealed class Process : Entity
	{	
		public static readonly int? EntityTypeCode = 4703;
		public new const string LogicalName = "workflow";
		public const string PrimaryIdAttribute = "workflowid";
		public const string PrimaryNameAttribute = "name";
	
		public Process() : base("workflow") { }

		#region Attributes
		/// <summary>
        /// activeworkflowid
        /// </summary>
		[DisplayName("Active Process ID")]
		[AttributeLogicalName("activeworkflowid")]
		public EntityReference ActiveProcessID
		{	
			get { return GetAttributeValue<EntityReference>("activeworkflowid"); }
			set
			{ 
				if(value == ActiveProcessID) return;
				SetAttributeValue("activeworkflowid", value);
			}
		}	
			
		/// <summary>
        /// activeworkflowidname
        /// </summary>
		[DisplayName("activeworkflowidname")]
		[AttributeLogicalName("activeworkflowidname")]
		public string Activeworkflowidname
		{	
			get { return GetAttributeValue<string>("activeworkflowidname"); }
			set
			{ 
				if(value == Activeworkflowidname) return;
				SetAttributeValue("activeworkflowidname", value);
			}
		}	
			
		/// <summary>
        /// asyncautodelete
        /// </summary>
		[DisplayName("Delete Job On Completion")]
		[AttributeLogicalName("asyncautodelete")]
		public bool? DeleteJobOnCompletion
		{	
			get { return GetAttributeValue<bool?>("asyncautodelete"); }
			set
			{ 
				if(value == DeleteJobOnCompletion) return;
				SetAttributeValue("asyncautodelete", value);
			}
		}	
			
		/// <summary>
        /// businessprocesstype
        /// </summary>
		[DisplayName("Business Process Type")]
		[AttributeLogicalName("businessprocesstype")]
		public eBusinessProcessType? BusinessProcessType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("businessprocesstype");
				if (optionSetValue != null) return (eBusinessProcessType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == BusinessProcessType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("businessprocesstype", optionSetValue); 
			}
		}

		/// <summary>
        /// category
        /// </summary>
		[DisplayName("Category")]
		[AttributeLogicalName("category")]
		public eCategory? Category
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("category");
				if (optionSetValue != null) return (eCategory)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Category) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("category", optionSetValue); 
			}
		}

		/// <summary>
        /// clientdata
        /// </summary>
		[DisplayName("Client Data")]
		[AttributeLogicalName("clientdata")]
		public string ClientData
		{	
			get { return GetAttributeValue<string>("clientdata"); }
			set
			{ 
				if(value == ClientData) return;
				SetAttributeValue("clientdata", value);
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
        /// createstage
        /// </summary>
		[DisplayName("Create Stage")]
		[AttributeLogicalName("createstage")]
		public egWorkflowStage? CreateStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("createstage");
				if (optionSetValue != null) return (egWorkflowStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CreateStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("createstage", optionSetValue); 
			}
		}

		/// <summary>
        /// deletestage
        /// </summary>
		[DisplayName("Delete stage")]
		[AttributeLogicalName("deletestage")]
		public egWorkflowStage? DeleteStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("deletestage");
				if (optionSetValue != null) return (egWorkflowStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DeleteStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("deletestage", optionSetValue); 
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
        /// entityimage_timestamp
        /// </summary>
		[DisplayName("entityimage_timestamp")]
		[AttributeLogicalName("entityimage_timestamp")]
		public int? EntityimageTimestamp
		{	
			get { return GetAttributeValue<int?>("entityimage_timestamp"); }
			set
			{ 
				if(value == EntityimageTimestamp) return;
				SetAttributeValue("entityimage_timestamp", value);
			}
		}	
			
		/// <summary>
        /// entityimage_url
        /// </summary>
		[DisplayName("entityimage_url")]
		[AttributeLogicalName("entityimage_url")]
		public string EntityimageUrl
		{	
			get { return GetAttributeValue<string>("entityimage_url"); }
			set
			{ 
				if(value == EntityimageUrl) return;
				SetAttributeValue("entityimage_url", value);
			}
		}	
			
		/// <summary>
        /// entityimageid
        /// </summary>
		[DisplayName("Entity Image Id")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityImageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityImageId) return;
				SetAttributeValue("entityimageid", value);
			}
		}	
			
		/// <summary>
        /// formid
        /// </summary>
		[DisplayName("Form ID")]
		[AttributeLogicalName("formid")]
		public Guid FormId
		{	
			get { return GetAttributeValue<Guid>("formid"); }
			set
			{ 
				if(value == FormId) return;
				SetAttributeValue("formid", value);
			}
		}	
			
		/// <summary>
        /// inputparameters
        /// </summary>
		[DisplayName("Input Parameters")]
		[AttributeLogicalName("inputparameters")]
		public string InputParameters
		{	
			get { return GetAttributeValue<string>("inputparameters"); }
			set
			{ 
				if(value == InputParameters) return;
				SetAttributeValue("inputparameters", value);
			}
		}	
			
		/// <summary>
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
			}
		}	
			
		/// <summary>
        /// iscrmuiworkflow
        /// </summary>
		[DisplayName("Is CRM Process")]
		[AttributeLogicalName("iscrmuiworkflow")]
		public bool? IsCRMProcess
		{	
			get { return GetAttributeValue<bool?>("iscrmuiworkflow"); }
			set
			{ 
				if(value == IsCRMProcess) return;
				SetAttributeValue("iscrmuiworkflow", value);
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
        /// istransacted
        /// </summary>
		[DisplayName("Is Transacted")]
		[AttributeLogicalName("istransacted")]
		public bool? IsTransacted
		{	
			get { return GetAttributeValue<bool?>("istransacted"); }
			set
			{ 
				if(value == IsTransacted) return;
				SetAttributeValue("istransacted", value);
			}
		}	
			
		/// <summary>
        /// languagecode
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("languagecode")]
		public int? Language
		{	
			get { return GetAttributeValue<int?>("languagecode"); }
			set
			{ 
				if(value == Language) return;
				SetAttributeValue("languagecode", value);
			}
		}	
			
		/// <summary>
        /// mode
        /// </summary>
		[DisplayName("Mode")]
		[AttributeLogicalName("mode")]
		public eMode? Mode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("mode");
				if (optionSetValue != null) return (eMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Mode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("mode", optionSetValue); 
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
		[DisplayName("Process Name")]
		[AttributeLogicalName("name")]
		public string ProcessName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == ProcessName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// ondemand
        /// </summary>
		[DisplayName("Run as On Demand")]
		[AttributeLogicalName("ondemand")]
		public bool? RunAsOnDemand
		{	
			get { return GetAttributeValue<bool?>("ondemand"); }
			set
			{ 
				if(value == RunAsOnDemand) return;
				SetAttributeValue("ondemand", value);
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
        /// owningbusinessunitname
        /// </summary>
		[DisplayName("owningbusinessunitname")]
		[AttributeLogicalName("owningbusinessunitname")]
		public string Owningbusinessunitname
		{	
			get { return GetAttributeValue<string>("owningbusinessunitname"); }
			set
			{ 
				if(value == Owningbusinessunitname) return;
				SetAttributeValue("owningbusinessunitname", value);
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
        /// parentworkflowid
        /// </summary>
		[DisplayName("Parent Process ID")]
		[AttributeLogicalName("parentworkflowid")]
		public EntityReference ParentProcessID
		{	
			get { return GetAttributeValue<EntityReference>("parentworkflowid"); }
			set
			{ 
				if(value == ParentProcessID) return;
				SetAttributeValue("parentworkflowid", value);
			}
		}	
			
		/// <summary>
        /// parentworkflowidname
        /// </summary>
		[DisplayName("parentworkflowidname")]
		[AttributeLogicalName("parentworkflowidname")]
		public string Parentworkflowidname
		{	
			get { return GetAttributeValue<string>("parentworkflowidname"); }
			set
			{ 
				if(value == Parentworkflowidname) return;
				SetAttributeValue("parentworkflowidname", value);
			}
		}	
			
		/// <summary>
        /// plugintypeid
        /// </summary>
		[DisplayName("plugintypeid")]
		[AttributeLogicalName("plugintypeid")]
		public EntityReference Plugintypeid
		{	
			get { return GetAttributeValue<EntityReference>("plugintypeid"); }
			set
			{ 
				if(value == Plugintypeid) return;
				SetAttributeValue("plugintypeid", value);
			}
		}	
			
		/// <summary>
        /// primaryentity
        /// </summary>
		[DisplayName("Primary Entity")]
		[AttributeLogicalName("primaryentity")]
		public string PrimaryEntity
		{	
			get { return GetAttributeValue<string>("primaryentity"); }
			set
			{ 
				if(value == PrimaryEntity) return;
				SetAttributeValue("primaryentity", value);
			}
		}	
			
		/// <summary>
        /// processorder
        /// </summary>
		[DisplayName("Process Order")]
		[AttributeLogicalName("processorder")]
		public int? ProcessOrder
		{	
			get { return GetAttributeValue<int?>("processorder"); }
			set
			{ 
				if(value == ProcessOrder) return;
				SetAttributeValue("processorder", value);
			}
		}	
			
		/// <summary>
        /// processroleassignment
        /// </summary>
		[DisplayName("Role assignment for Process")]
		[AttributeLogicalName("processroleassignment")]
		public string RoleAssignmentForProcess
		{	
			get { return GetAttributeValue<string>("processroleassignment"); }
			set
			{ 
				if(value == RoleAssignmentForProcess) return;
				SetAttributeValue("processroleassignment", value);
			}
		}	
			
		/// <summary>
        /// processtriggerformid
        /// </summary>
		[DisplayName("ProcessTriggerFormId")]
		[AttributeLogicalName("processtriggerformid")]
		public Guid ProcessTriggerFormId
		{	
			get { return GetAttributeValue<Guid>("processtriggerformid"); }
			set
			{ 
				if(value == ProcessTriggerFormId) return;
				SetAttributeValue("processtriggerformid", value);
			}
		}	
			
		/// <summary>
        /// processtriggerscope
        /// </summary>
		[DisplayName("ProcessTriggerScope")]
		[AttributeLogicalName("processtriggerscope")]
		public eProcesstriggerScope? ProcessTriggerScope
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("processtriggerscope");
				if (optionSetValue != null) return (eProcesstriggerScope)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProcessTriggerScope) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("processtriggerscope", optionSetValue); 
			}
		}

		/// <summary>
        /// rank
        /// </summary>
		[DisplayName("Rank")]
		[AttributeLogicalName("rank")]
		public int? Rank
		{	
			get { return GetAttributeValue<int?>("rank"); }
			set
			{ 
				if(value == Rank) return;
				SetAttributeValue("rank", value);
			}
		}	
			
		/// <summary>
        /// rendererobjecttypecode
        /// </summary>
		[DisplayName("Renderer Type")]
		[AttributeLogicalName("rendererobjecttypecode")]
		public string RendererType
		{	
			get { return GetAttributeValue<string>("rendererobjecttypecode"); }
			set
			{ 
				if(value == RendererType) return;
				SetAttributeValue("rendererobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// runas
        /// </summary>
		[DisplayName("Run As User")]
		[AttributeLogicalName("runas")]
		public egExecutingUser? RunAsUser
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("runas");
				if (optionSetValue != null) return (egExecutingUser)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RunAsUser) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("runas", optionSetValue); 
			}
		}

		/// <summary>
        /// scope
        /// </summary>
		[DisplayName("Scope")]
		[AttributeLogicalName("scope")]
		public eScope? Scope
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("scope");
				if (optionSetValue != null) return (eScope)optionSetValue.Value;
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
        /// sdkmessageid
        /// </summary>
		[DisplayName("SDK Message")]
		[AttributeLogicalName("sdkmessageid")]
		public EntityReference SDKMessage
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
			set
			{ 
				if(value == SDKMessage) return;
				SetAttributeValue("sdkmessageid", value);
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
        /// subprocess
        /// </summary>
		[DisplayName("Is Child Process")]
		[AttributeLogicalName("subprocess")]
		public bool? IsChildProcess
		{	
			get { return GetAttributeValue<bool?>("subprocess"); }
			set
			{ 
				if(value == IsChildProcess) return;
				SetAttributeValue("subprocess", value);
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
        /// syncworkflowlogonfailure
        /// </summary>
		[DisplayName("Log upon Failure")]
		[AttributeLogicalName("syncworkflowlogonfailure")]
		public bool? LogUponFailure
		{	
			get { return GetAttributeValue<bool?>("syncworkflowlogonfailure"); }
			set
			{ 
				if(value == LogUponFailure) return;
				SetAttributeValue("syncworkflowlogonfailure", value);
			}
		}	
			
		/// <summary>
        /// triggeroncreate
        /// </summary>
		[DisplayName("Trigger On Create")]
		[AttributeLogicalName("triggeroncreate")]
		public bool? TriggerOnCreate
		{	
			get { return GetAttributeValue<bool?>("triggeroncreate"); }
			set
			{ 
				if(value == TriggerOnCreate) return;
				SetAttributeValue("triggeroncreate", value);
			}
		}	
			
		/// <summary>
        /// triggerondelete
        /// </summary>
		[DisplayName("Trigger On Delete")]
		[AttributeLogicalName("triggerondelete")]
		public bool? TriggerOnDelete
		{	
			get { return GetAttributeValue<bool?>("triggerondelete"); }
			set
			{ 
				if(value == TriggerOnDelete) return;
				SetAttributeValue("triggerondelete", value);
			}
		}	
			
		/// <summary>
        /// triggeronupdateattributelist
        /// </summary>
		[DisplayName("Trigger On Update Attribute List")]
		[AttributeLogicalName("triggeronupdateattributelist")]
		public string TriggerOnUpdateAttributeList
		{	
			get { return GetAttributeValue<string>("triggeronupdateattributelist"); }
			set
			{ 
				if(value == TriggerOnUpdateAttributeList) return;
				SetAttributeValue("triggeronupdateattributelist", value);
			}
		}	
			
		/// <summary>
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
			}
		}

		/// <summary>
        /// uidata
        /// </summary>
		[DisplayName("UI Data")]
		[AttributeLogicalName("uidata")]
		public string UIData
		{	
			get { return GetAttributeValue<string>("uidata"); }
			set
			{ 
				if(value == UIData) return;
				SetAttributeValue("uidata", value);
			}
		}	
			
		/// <summary>
        /// uiflowtype
        /// </summary>
		[DisplayName("Desktop Flow Type")]
		[AttributeLogicalName("uiflowtype")]
		public eDesktopFlowType? DesktopFlowType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("uiflowtype");
				if (optionSetValue != null) return (eDesktopFlowType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DesktopFlowType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("uiflowtype", optionSetValue); 
			}
		}

		/// <summary>
        /// uniquename
        /// </summary>
		[DisplayName("Unique Name")]
		[AttributeLogicalName("uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("uniquename"); }
			set
			{ 
				if(value == UniqueName) return;
				SetAttributeValue("uniquename", value);
			}
		}	
			
		/// <summary>
        /// updatestage
        /// </summary>
		[DisplayName("Update Stage")]
		[AttributeLogicalName("updatestage")]
		public egWorkflowStage? UpdateStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("updatestage");
				if (optionSetValue != null) return (egWorkflowStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == UpdateStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("updatestage", optionSetValue); 
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
			
		/// <summary>
        /// workflowid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("workflowid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("workflowid", value); }
		}

							/// <summary>
        /// workflowidunique
        /// </summary>
		[DisplayName("workflowidunique")]
		[AttributeLogicalName("workflowidunique")]
		public Guid WorkflowiduniqueId
		{	
			get { return GetAttributeValue<Guid>("workflowidunique"); }
			set
			{ 
				if(value == WorkflowiduniqueId) return;
				SetAttributeValue("workflowidunique", value);
			}
		}	
			
		/// <summary>
        /// xaml
        /// </summary>
		[DisplayName("xaml")]
		[AttributeLogicalName("xaml")]
		public string Xaml
		{	
			get { return GetAttributeValue<string>("xaml"); }
			set
			{ 
				if(value == Xaml) return;
				SetAttributeValue("xaml", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'catalogassignment_workflow'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_workflow")]
		public IEnumerable<CatalogAssignment> CatalogassignmentWorkflow
		{
			get { return GetRelatedEntities<CatalogAssignment>("catalogassignment_workflow", null); }
			set { SetRelatedEntities("catalogassignment_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_asyncoperation_workflowactivationid'
        /// </summary>
		[RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
		public IEnumerable<SystemJob> LkAsyncoperationWorkflowactivationid
		{
			get { return GetRelatedEntities<SystemJob>("lk_asyncoperation_workflowactivationid", null); }
			set { SetRelatedEntities("lk_asyncoperation_workflowactivationid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_expiredprocess_processid'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_processid")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessProcessid
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_processid", null); }
			set { SetRelatedEntities("lk_expiredprocess_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_processid'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_processid")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessProcessid
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_processid", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_processid'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_processid")]
		public IEnumerable<NewProcess> LkNewprocessProcessid
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_processid", null); }
			set { SetRelatedEntities("lk_newprocess_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_processid'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_processid")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessProcessid
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_processid", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_processid'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_processid")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessProcessid
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_processid", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_processid'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_processid")]
		public IEnumerable<ProcessSession> LkProcesssessionProcessid
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_processid", null); }
			set { SetRelatedEntities("lk_processsession_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_processid'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_processid")]
		public IEnumerable<TranslationProcess> LkTranslationprocessProcessid
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_processid", null); }
			set { SetRelatedEntities("lk_translationprocess_processid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_retrainworkflow_msdyn_toaimodel'
        /// </summary>
		[RelationshipSchemaName("msdyn_retrainworkflow_msdyn_toaimodel")]
		public IEnumerable<AIModel> MsdynRetrainworkflowMsdynToaimodel
		{
			get { return GetRelatedEntities<AIModel>("msdyn_retrainworkflow_msdyn_toaimodel", null); }
			set { SetRelatedEntities("msdyn_retrainworkflow_msdyn_toaimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_scheduleinferenceworkflow_msdyn_toaimodel'
        /// </summary>
		[RelationshipSchemaName("msdyn_scheduleinferenceworkflow_msdyn_toaimodel")]
		public IEnumerable<AIModel> MsdynScheduleinferenceworkflowMsdynToaimodel
		{
			get { return GetRelatedEntities<AIModel>("msdyn_scheduleinferenceworkflow_msdyn_toaimodel", null); }
			set { SetRelatedEntities("msdyn_scheduleinferenceworkflow_msdyn_toaimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'process_processstage'
        /// </summary>
		[RelationshipSchemaName("process_processstage")]
		public IEnumerable<ProcessStage> ProcessProcessstage
		{
			get { return GetRelatedEntities<ProcessStage>("process_processstage", null); }
			set { SetRelatedEntities("process_processstage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'process_processtrigger'
        /// </summary>
		[RelationshipSchemaName("process_processtrigger")]
		public IEnumerable<ProcessTrigger> ProcessProcesstrigger
		{
			get { return GetRelatedEntities<ProcessTrigger>("process_processtrigger", null); }
			set { SetRelatedEntities("process_processtrigger", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_workflow_pw_schedule_action'
        /// </summary>
		[RelationshipSchemaName("pw_workflow_pw_schedule_action")]
		public IEnumerable<PentaSchedule> PwWorkflowPwScheduleAction
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_workflow_pw_schedule_action", null); }
			set { SetRelatedEntities("pw_workflow_pw_schedule_action", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_workflow_pw_schedule_global_action'
        /// </summary>
		[RelationshipSchemaName("pw_workflow_pw_schedule_global_action")]
		public IEnumerable<PentaSchedule> PwWorkflowPwScheduleGlobalAction
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_workflow_pw_schedule_global_action", null); }
			set { SetRelatedEntities("pw_workflow_pw_schedule_global_action", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_workflow_pw_schedule_workflow'
        /// </summary>
		[RelationshipSchemaName("pw_workflow_pw_schedule_workflow")]
		public IEnumerable<PentaSchedule> PwWorkflowPwScheduleWorkflow
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_workflow_pw_schedule_workflow", null); }
			set { SetRelatedEntities("pw_workflow_pw_schedule_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'regardingobjectid_process'
        /// </summary>
		[RelationshipSchemaName("regardingobjectid_process")]
		public IEnumerable<FlowSession> RegardingobjectidProcess
		{
			get { return GetRelatedEntities<FlowSession>("regardingobjectid_process", null); }
			set { SetRelatedEntities("regardingobjectid_process", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slabase_workflowid'
        /// </summary>
		[RelationshipSchemaName("slabase_workflowid")]
		public IEnumerable<SLA> SlabaseWorkflowid
		{
			get { return GetRelatedEntities<SLA>("slabase_workflowid", null); }
			set { SetRelatedEntities("slabase_workflowid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slaitembase_workflowid'
        /// </summary>
		[RelationshipSchemaName("slaitembase_workflowid")]
		public IEnumerable<SLAItem> SlaitembaseWorkflowid
		{
			get { return GetRelatedEntities<SLAItem>("slaitembase_workflowid", null); }
			set { SetRelatedEntities("slaitembase_workflowid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_active_workflow'
        /// </summary>
		[RelationshipSchemaName("workflow_active_workflow")]
		public IEnumerable<Process> WorkflowActiveWorkflow
		{
			get { return GetRelatedEntities<Process>("workflow_active_workflow", null); }
			set { SetRelatedEntities("workflow_active_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Workflow_Annotation'
        /// </summary>
		[RelationshipSchemaName("Workflow_Annotation")]
		public IEnumerable<Note> WorkflowAnnotation
		{
			get { return GetRelatedEntities<Note>("Workflow_Annotation", null); }
			set { SetRelatedEntities("Workflow_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_parent_workflow'
        /// </summary>
		[RelationshipSchemaName("workflow_parent_workflow")]
		public IEnumerable<Process> WorkflowParentWorkflow
		{
			get { return GetRelatedEntities<Process>("workflow_parent_workflow", null); }
			set { SetRelatedEntities("workflow_parent_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Workflow_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Workflow_SyncErrors")]
		public IEnumerable<SyncError> WorkflowSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Workflow_SyncErrors", null); }
			set { SetRelatedEntities("Workflow_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_workflowbinary_Process'
        /// </summary>
		[RelationshipSchemaName("workflow_workflowbinary_Process")]
		public IEnumerable<WorkflowBinary> WorkflowWorkflowbinaryProcess
		{
			get { return GetRelatedEntities<WorkflowBinary>("workflow_workflowbinary_Process", null); }
			set { SetRelatedEntities("workflow_workflowbinary_Process", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'ChatbotSubcomponent'
        /// </summary>
		[RelationshipSchemaName("botcomponent_workflow")]
		public IEnumerable<ChatbotSubcomponent> BotcomponentWorkflow
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("botcomponent_workflow", null); }
			set { SetRelatedEntities("botcomponent_workflow", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecuteInstall(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("install");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
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
		
		public enum eProcesstriggerScope
		{	
		
			[Label("Form")]
			[Description(@"")]
			Form = 1, 
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 2, 
		}
		
		public enum eBusinessProcessType
		{	
		
			[Label("Business Flow")]
			[Description(@"")]
			BusinessFlow = 0, 
		
			[Label("Task Flow")]
			[Description(@"")]
			TaskFlow = 1, 
		}
		
		public enum eCategory
		{	
		
			[Label("Workflow")]
			[Description(@"")]
			Workflow = 0, 
		
			[Label("Dialog")]
			[Description(@"")]
			Dialog = 1, 
		
			[Label("Business Rule")]
			[Description(@"")]
			BusinessRule = 2, 
		
			[Label("Action")]
			[Description(@"")]
			Action = 3, 
		
			[Label("Business Process Flow")]
			[Description(@"")]
			BusinessProcessFlow = 4, 
		
			[Label("Modern Flow")]
			[Description(@"")]
			ModernFlow = 5, 
		
			[Label("Desktop Flow")]
			[Description(@"")]
			DesktopFlow = 6, 
		}
		
		public enum eMode
		{	
		
			[Label("Background")]
			[Description(@"")]
			Background = 0, 
		
			[Label("Real-time")]
			[Description(@"")]
			Realtime = 1, 
		}
		
		public enum egExecutingUser
		{	
		
			[Label("Owner")]
			[Description(@"")]
			Owner = 0, 
		
			[Label("Calling User")]
			[Description(@"")]
			CallingUser = 1, 
		}
		
		public enum eScope
		{	
		
			[Label("User")]
			[Description(@"")]
			User = 1, 
		
			[Label("Business Unit")]
			[Description(@"")]
			BusinessUnit = 2, 
		
			[Label("Parent: Child Business Units")]
			[Description(@"")]
			ParentChildBusinessUnits = 3, 
		
			[Label("Organization")]
			[Description(@"")]
			Organization = 4, 
		}
		
		public enum egWorkflowStage
		{	
		
			[Label("Pre-operation")]
			[Description(@"")]
			Preoperation = 20, 
		
			[Label("Post-operation")]
			[Description(@"")]
			Postoperation = 40, 
		}
		
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Activated")]
			[Description(@"")]
			Activated = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 1, 
		
			[Label("Activated")]
			[Description(@"")]
			Activated_Inactive = 2, 
		}
		
		public enum eType
		{	
		
			[Label("Definition")]
			[Description(@"")]
			Definition = 1, 
		
			[Label("Activation")]
			[Description(@"")]
			Activation = 2, 
		
			[Label("Template")]
			[Description(@"")]
			Template = 3, 
		}
		
		public enum eDesktopFlowType
		{	
		
			[Label("Windows recorder (V1)")]
			[Description(@"")]
			WindowsRecorderV1 = 0, 
		
			[Label("Selenium IDE")]
			[Description(@"")]
			SeleniumIDE = 1, 
		
			[Label("Power Automate Desktop")]
			[Description(@"")]
			PowerAutomateDesktop = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activeworkflowid</summary>
			public const string ActiveProcessID = "activeworkflowid";

			/// <summary>activeworkflowidname</summary>
			public const string Activeworkflowidname = "activeworkflowidname";

			/// <summary>asyncautodelete</summary>
			public const string DeleteJobOnCompletion = "asyncautodelete";

			/// <summary>businessprocesstype</summary>
			public const string BusinessProcessType = "businessprocesstype";

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>clientdata</summary>
			public const string ClientData = "clientdata";

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

			/// <summary>createstage</summary>
			public const string CreateStage = "createstage";

			/// <summary>deletestage</summary>
			public const string DeleteStage = "deletestage";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>formid</summary>
			public const string FormId = "formid";

			/// <summary>inputparameters</summary>
			public const string InputParameters = "inputparameters";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>iscrmuiworkflow</summary>
			public const string IsCRMProcess = "iscrmuiworkflow";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>istransacted</summary>
			public const string IsTransacted = "istransacted";

			/// <summary>languagecode</summary>
			public const string Language = "languagecode";

			/// <summary>mode</summary>
			public const string Mode = "mode";

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
			public const string ProcessName = "name";

			/// <summary>ondemand</summary>
			public const string RunAsOnDemand = "ondemand";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

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

			/// <summary>owningbusinessunitname</summary>
			public const string Owningbusinessunitname = "owningbusinessunitname";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentworkflowid</summary>
			public const string ParentProcessID = "parentworkflowid";

			/// <summary>parentworkflowidname</summary>
			public const string Parentworkflowidname = "parentworkflowidname";

			/// <summary>plugintypeid</summary>
			public const string Plugintypeid = "plugintypeid";

			/// <summary>primaryentity</summary>
			public const string PrimaryEntity = "primaryentity";

			/// <summary>processorder</summary>
			public const string ProcessOrder = "processorder";

			/// <summary>processroleassignment</summary>
			public const string RoleAssignmentForProcess = "processroleassignment";

			/// <summary>processtriggerformid</summary>
			public const string ProcessTriggerFormId = "processtriggerformid";

			/// <summary>processtriggerscope</summary>
			public const string ProcessTriggerScope = "processtriggerscope";

			/// <summary>rank</summary>
			public const string Rank = "rank";

			/// <summary>rendererobjecttypecode</summary>
			public const string RendererType = "rendererobjecttypecode";

			/// <summary>runas</summary>
			public const string RunAsUser = "runas";

			/// <summary>scope</summary>
			public const string Scope = "scope";

			/// <summary>sdkmessageid</summary>
			public const string SDKMessage = "sdkmessageid";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subprocess</summary>
			public const string IsChildProcess = "subprocess";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>syncworkflowlogonfailure</summary>
			public const string LogUponFailure = "syncworkflowlogonfailure";

			/// <summary>triggeroncreate</summary>
			public const string TriggerOnCreate = "triggeroncreate";

			/// <summary>triggerondelete</summary>
			public const string TriggerOnDelete = "triggerondelete";

			/// <summary>triggeronupdateattributelist</summary>
			public const string TriggerOnUpdateAttributeList = "triggeronupdateattributelist";

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>uidata</summary>
			public const string UIData = "uidata";

			/// <summary>uiflowtype</summary>
			public const string DesktopFlowType = "uiflowtype";

			/// <summary>uniquename</summary>
			public const string UniqueName = "uniquename";

			/// <summary>updatestage</summary>
			public const string UpdateStage = "updatestage";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>workflowid</summary>
			public const string ProcessId = "workflowid";

			/// <summary>workflowidunique</summary>
			public const string WorkflowiduniqueId = "workflowidunique";

			/// <summary>xaml</summary>
			public const string Xaml = "xaml";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N catalogassignment_workflow</summary>
			public const string CatalogassignmentWorkflow = "catalogassignment_workflow";

			/// <summary>1:N lk_asyncoperation_workflowactivationid</summary>
			public const string LkAsyncoperationWorkflowactivationid = "lk_asyncoperation_workflowactivationid";

			/// <summary>1:N lk_expiredprocess_processid</summary>
			public const string LkExpiredprocessProcessid = "lk_expiredprocess_processid";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_processid</summary>
			public const string LkLeadtoopportunitysalesprocessProcessid = "lk_leadtoopportunitysalesprocess_processid";

			/// <summary>1:N lk_newprocess_processid</summary>
			public const string LkNewprocessProcessid = "lk_newprocess_processid";

			/// <summary>1:N lk_opportunitysalesprocess_processid</summary>
			public const string LkOpportunitysalesprocessProcessid = "lk_opportunitysalesprocess_processid";

			/// <summary>1:N lk_phonetocaseprocess_processid</summary>
			public const string LkPhonetocaseprocessProcessid = "lk_phonetocaseprocess_processid";

			/// <summary>1:N lk_processsession_processid</summary>
			public const string LkProcesssessionProcessid = "lk_processsession_processid";

			/// <summary>1:N lk_translationprocess_processid</summary>
			public const string LkTranslationprocessProcessid = "lk_translationprocess_processid";

			/// <summary>1:N msdyn_retrainworkflow_msdyn_toaimodel</summary>
			public const string MsdynRetrainworkflowMsdynToaimodel = "msdyn_retrainworkflow_msdyn_toaimodel";

			/// <summary>1:N msdyn_scheduleinferenceworkflow_msdyn_toaimodel</summary>
			public const string MsdynScheduleinferenceworkflowMsdynToaimodel = "msdyn_scheduleinferenceworkflow_msdyn_toaimodel";

			/// <summary>1:N process_processstage</summary>
			public const string ProcessProcessstage = "process_processstage";

			/// <summary>1:N process_processtrigger</summary>
			public const string ProcessProcesstrigger = "process_processtrigger";

			/// <summary>1:N pw_workflow_pw_schedule_action</summary>
			public const string PwWorkflowPwScheduleAction = "pw_workflow_pw_schedule_action";

			/// <summary>1:N pw_workflow_pw_schedule_global_action</summary>
			public const string PwWorkflowPwScheduleGlobalAction = "pw_workflow_pw_schedule_global_action";

			/// <summary>1:N pw_workflow_pw_schedule_workflow</summary>
			public const string PwWorkflowPwScheduleWorkflow = "pw_workflow_pw_schedule_workflow";

			/// <summary>1:N regardingobjectid_process</summary>
			public const string RegardingobjectidProcess = "regardingobjectid_process";

			/// <summary>1:N slabase_workflowid</summary>
			public const string SlabaseWorkflowid = "slabase_workflowid";

			/// <summary>1:N slaitembase_workflowid</summary>
			public const string SlaitembaseWorkflowid = "slaitembase_workflowid";

			/// <summary>1:N workflow_active_workflow</summary>
			public const string WorkflowActiveWorkflow = "workflow_active_workflow";

			/// <summary>1:N Workflow_Annotation</summary>
			public const string WorkflowAnnotation = "Workflow_Annotation";

			/// <summary>1:N workflow_parent_workflow</summary>
			public const string WorkflowParentWorkflow = "workflow_parent_workflow";

			/// <summary>1:N Workflow_SyncErrors</summary>
			public const string WorkflowSyncErrors = "Workflow_SyncErrors";

			/// <summary>1:N workflow_workflowbinary_Process</summary>
			public const string WorkflowWorkflowbinaryProcess = "workflow_workflowbinary_Process";

			/// <summary>N:N botcomponent_workflow</summary>
			public const string BotcomponentWorkflow = "botcomponent_workflow";

		}
		#endregion
	}
}

