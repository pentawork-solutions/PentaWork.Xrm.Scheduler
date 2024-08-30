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
				if(Attributes.ContainsKey("activeworkflowid") && value == ActiveProcessID) return;
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
				if(Attributes.ContainsKey("activeworkflowidname") && value == Activeworkflowidname) return;
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
				if(Attributes.ContainsKey("asyncautodelete") && value == DeleteJobOnCompletion) return;
				SetAttributeValue("asyncautodelete", value);
			}
		}	
			
		/// <summary>
        /// billingcontext
        /// </summary>
		[DisplayName("BillingContext")]
		[AttributeLogicalName("billingcontext")]
		public string BillingContext
		{	
			get { return GetAttributeValue<string>("billingcontext"); }
			set
			{ 
				if(Attributes.ContainsKey("billingcontext") && value == BillingContext) return;
				SetAttributeValue("billingcontext", value);
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
				if(Attributes.ContainsKey("businessprocesstype") && value == BusinessProcessType) return;

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
				if(Attributes.ContainsKey("category") && value == Category) return;

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
				if(Attributes.ContainsKey("clientdata") && value == ClientData) return;
				SetAttributeValue("clientdata", value);
			}
		}	
			
		/// <summary>
        /// clientdataiscompressed
        /// </summary>
		[DisplayName("Client Data Is Compressed")]
		[AttributeLogicalName("clientdataiscompressed")]
		public bool? ClientDataIsCompressed
		{	
			get { return GetAttributeValue<bool?>("clientdataiscompressed"); }
			set
			{ 
				if(Attributes.ContainsKey("clientdataiscompressed") && value == ClientDataIsCompressed) return;
				SetAttributeValue("clientdataiscompressed", value);
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
				if(Attributes.ContainsKey("componentstate") && value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
			}
		}

		/// <summary>
        /// connectionreferences
        /// </summary>
		[DisplayName("Connection references")]
		[AttributeLogicalName("connectionreferences")]
		public string ConnectionReferences
		{	
			get { return GetAttributeValue<string>("connectionreferences"); }
			set
			{ 
				if(Attributes.ContainsKey("connectionreferences") && value == ConnectionReferences) return;
				SetAttributeValue("connectionreferences", value);
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
				if(Attributes.ContainsKey("createdby") && value == CreatedBy) return;
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
				if(Attributes.ContainsKey("createdbyname") && value == Createdbyname) return;
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
				if(Attributes.ContainsKey("createdbyyominame") && value == Createdbyyominame) return;
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
				if(Attributes.ContainsKey("createdon") && value == CreatedOn) return;
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
				if(Attributes.ContainsKey("createdonbehalfby") && value == CreatedByDelegate) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyname") && value == Createdonbehalfbyname) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyyominame") && value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// createmetadata
        /// </summary>
		[DisplayName("Create metadata")]
		[AttributeLogicalName("createmetadata")]
		public string CreateMetadata
		{	
			get { return GetAttributeValue<string>("createmetadata"); }
			set
			{ 
				if(Attributes.ContainsKey("createmetadata") && value == CreateMetadata) return;
				SetAttributeValue("createmetadata", value);
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
				if(Attributes.ContainsKey("createstage") && value == CreateStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("createstage", optionSetValue); 
			}
		}

		/// <summary>
        /// definition
        /// </summary>
		[DisplayName("Definition")]
		[AttributeLogicalName("definition")]
		public string Definition
		{	
			get { return GetAttributeValue<string>("definition"); }
			set
			{ 
				if(Attributes.ContainsKey("definition") && value == Definition) return;
				SetAttributeValue("definition", value);
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
				if(Attributes.ContainsKey("deletestage") && value == DeleteStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("deletestage", optionSetValue); 
			}
		}

		/// <summary>
        /// dependencies
        /// </summary>
		[DisplayName("Dependencies")]
		[AttributeLogicalName("dependencies")]
		public string Dependencies
		{	
			get { return GetAttributeValue<string>("dependencies"); }
			set
			{ 
				if(Attributes.ContainsKey("dependencies") && value == Dependencies) return;
				SetAttributeValue("dependencies", value);
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
				if(Attributes.ContainsKey("description") && value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// desktopflowmodules
        /// </summary>
		[DisplayName("Desktop flow modules")]
		[AttributeLogicalName("desktopflowmodules")]
		public string DesktopFlowModules
		{	
			get { return GetAttributeValue<string>("desktopflowmodules"); }
			set
			{ 
				if(Attributes.ContainsKey("desktopflowmodules") && value == DesktopFlowModules) return;
				SetAttributeValue("desktopflowmodules", value);
			}
		}	
			
		/// <summary>
        /// dynamicssolutioncontext
        /// </summary>
		[DisplayName("DynamicsSolutionContext")]
		[AttributeLogicalName("dynamicssolutioncontext")]
		public string DynamicsSolutionContext
		{	
			get { return GetAttributeValue<string>("dynamicssolutioncontext"); }
			set
			{ 
				if(Attributes.ContainsKey("dynamicssolutioncontext") && value == DynamicsSolutionContext) return;
				SetAttributeValue("dynamicssolutioncontext", value);
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
				if(Attributes.ContainsKey("entityimage_timestamp") && value == EntityimageTimestamp) return;
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
				if(Attributes.ContainsKey("entityimage_url") && value == EntityimageUrl) return;
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
				if(Attributes.ContainsKey("entityimageid") && value == EntityImageId) return;
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
				if(Attributes.ContainsKey("formid") && value == FormId) return;
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
				if(Attributes.ContainsKey("inputparameters") && value == InputParameters) return;
				SetAttributeValue("inputparameters", value);
			}
		}	
			
		/// <summary>
        /// inputs
        /// </summary>
		[DisplayName("Inputs")]
		[AttributeLogicalName("inputs")]
		public string Inputs
		{	
			get { return GetAttributeValue<string>("inputs"); }
			set
			{ 
				if(Attributes.ContainsKey("inputs") && value == Inputs) return;
				SetAttributeValue("inputs", value);
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
				if(Attributes.ContainsKey("introducedversion") && value == IntroducedVersion) return;
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
				if(Attributes.ContainsKey("iscrmuiworkflow") && value == IsCRMProcess) return;
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
				if(Attributes.ContainsKey("ismanaged") && value == IsManaged) return;
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
				if(Attributes.ContainsKey("istransacted") && value == IsTransacted) return;
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
				if(Attributes.ContainsKey("languagecode") && value == Language) return;
				SetAttributeValue("languagecode", value);
			}
		}	
			
		/// <summary>
        /// licenseentitledby
        /// </summary>
		[DisplayName("License entitled by")]
		[AttributeLogicalName("licenseentitledby")]
		public EntityReference LicenseEntitledBy
		{	
			get { return GetAttributeValue<EntityReference>("licenseentitledby"); }
			set
			{ 
				if(Attributes.ContainsKey("licenseentitledby") && value == LicenseEntitledBy) return;
				SetAttributeValue("licenseentitledby", value);
			}
		}	
			
		/// <summary>
        /// licenseentitledbyname
        /// </summary>
		[DisplayName("licenseentitledbyname")]
		[AttributeLogicalName("licenseentitledbyname")]
		public string Licenseentitledbyname
		{	
			get { return GetAttributeValue<string>("licenseentitledbyname"); }
			set
			{ 
				if(Attributes.ContainsKey("licenseentitledbyname") && value == Licenseentitledbyname) return;
				SetAttributeValue("licenseentitledbyname", value);
			}
		}	
			
		/// <summary>
        /// metadata
        /// </summary>
		[DisplayName("Metadata")]
		[AttributeLogicalName("metadata")]
		public string Metadata
		{	
			get { return GetAttributeValue<string>("metadata"); }
			set
			{ 
				if(Attributes.ContainsKey("metadata") && value == Metadata) return;
				SetAttributeValue("metadata", value);
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
				if(Attributes.ContainsKey("mode") && value == Mode) return;

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
				if(Attributes.ContainsKey("modifiedby") && value == ModifiedBy) return;
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
				if(Attributes.ContainsKey("modifiedbyname") && value == Modifiedbyname) return;
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
				if(Attributes.ContainsKey("modifiedbyyominame") && value == Modifiedbyyominame) return;
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
				if(Attributes.ContainsKey("modifiedon") && value == ModifiedOn) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfby") && value == ModifiedByDelegate) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyname") && value == Modifiedonbehalfbyname) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyyominame") && value == Modifiedonbehalfbyyominame) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// modifymetadata
        /// </summary>
		[DisplayName("ModifyMetadata")]
		[AttributeLogicalName("modifymetadata")]
		public string ModifyMetadata
		{	
			get { return GetAttributeValue<string>("modifymetadata"); }
			set
			{ 
				if(Attributes.ContainsKey("modifymetadata") && value == ModifyMetadata) return;
				SetAttributeValue("modifymetadata", value);
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
				if(Attributes.ContainsKey("name") && value == ProcessName) return;
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
				if(Attributes.ContainsKey("ondemand") && value == RunAsOnDemand) return;
				SetAttributeValue("ondemand", value);
			}
		}	
			
		/// <summary>
        /// outputs
        /// </summary>
		[DisplayName("Outputs")]
		[AttributeLogicalName("outputs")]
		public string Outputs
		{	
			get { return GetAttributeValue<string>("outputs"); }
			set
			{ 
				if(Attributes.ContainsKey("outputs") && value == Outputs) return;
				SetAttributeValue("outputs", value);
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
				if(Attributes.ContainsKey("overwritetime") && value == RecordOverwriteTime) return;
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
				if(Attributes.ContainsKey("ownerid") && value == Owner) return;
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
				if(Attributes.ContainsKey("owneridname") && value == Owneridname) return;
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
				if(Attributes.ContainsKey("owneridtype") && value == Owneridtype) return;
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
				if(Attributes.ContainsKey("owneridyominame") && value == Owneridyominame) return;
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
				if(Attributes.ContainsKey("owningbusinessunit") && value == OwningBusinessUnit) return;
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
				if(Attributes.ContainsKey("owningbusinessunitname") && value == Owningbusinessunitname) return;
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
				if(Attributes.ContainsKey("owningteam") && value == OwningTeam) return;
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
				if(Attributes.ContainsKey("owninguser") && value == OwningUser) return;
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
				if(Attributes.ContainsKey("parentworkflowid") && value == ParentProcessID) return;
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
				if(Attributes.ContainsKey("parentworkflowidname") && value == Parentworkflowidname) return;
				SetAttributeValue("parentworkflowidname", value);
			}
		}	
			
		/// <summary>
        /// planverified
        /// </summary>
		[DisplayName("Plan Verified")]
		[AttributeLogicalName("planverified")]
		public bool? PlanVerified
		{	
			get { return GetAttributeValue<bool?>("planverified"); }
			set
			{ 
				if(Attributes.ContainsKey("planverified") && value == PlanVerified) return;
				SetAttributeValue("planverified", value);
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
				if(Attributes.ContainsKey("plugintypeid") && value == Plugintypeid) return;
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
				if(Attributes.ContainsKey("primaryentity") && value == PrimaryEntity) return;
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
				if(Attributes.ContainsKey("processorder") && value == ProcessOrder) return;
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
				if(Attributes.ContainsKey("processroleassignment") && value == RoleAssignmentForProcess) return;
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
				if(Attributes.ContainsKey("processtriggerformid") && value == ProcessTriggerFormId) return;
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
				if(Attributes.ContainsKey("processtriggerscope") && value == ProcessTriggerScope) return;

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
				if(Attributes.ContainsKey("rank") && value == Rank) return;
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
				if(Attributes.ContainsKey("rendererobjecttypecode") && value == RendererType) return;
				SetAttributeValue("rendererobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// resourcecontainer
        /// </summary>
		[DisplayName("ResourceContainer")]
		[AttributeLogicalName("resourcecontainer")]
		public string ResourceContainer
		{	
			get { return GetAttributeValue<string>("resourcecontainer"); }
			set
			{ 
				if(Attributes.ContainsKey("resourcecontainer") && value == ResourceContainer) return;
				SetAttributeValue("resourcecontainer", value);
			}
		}	
			
		/// <summary>
        /// resourceid
        /// </summary>
		[DisplayName("ResourceId")]
		[AttributeLogicalName("resourceid")]
		public Guid ResourceId
		{	
			get { return GetAttributeValue<Guid>("resourceid"); }
			set
			{ 
				if(Attributes.ContainsKey("resourceid") && value == ResourceId) return;
				SetAttributeValue("resourceid", value);
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
				if(Attributes.ContainsKey("runas") && value == RunAsUser) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("runas", optionSetValue); 
			}
		}

		/// <summary>
        /// schemaversion
        /// </summary>
		[DisplayName("Schema Version")]
		[AttributeLogicalName("schemaversion")]
		public string SchemaVersion
		{	
			get { return GetAttributeValue<string>("schemaversion"); }
			set
			{ 
				if(Attributes.ContainsKey("schemaversion") && value == SchemaVersion) return;
				SetAttributeValue("schemaversion", value);
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
				if(Attributes.ContainsKey("scope") && value == Scope) return;

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
				if(Attributes.ContainsKey("sdkmessageid") && value == SDKMessage) return;
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
				if(Attributes.ContainsKey("solutionid") && value == SolutionId) return;
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
				if(Attributes.ContainsKey("statecode") && value == Status) return;

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
				if(Attributes.ContainsKey("statuscode") && value == StatusReason) return;

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
				if(Attributes.ContainsKey("subprocess") && value == IsChildProcess) return;
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
				if(Attributes.ContainsKey("supportingsolutionid") && value == SolutionId2) return;
				SetAttributeValue("supportingsolutionid", value);
			}
		}	
			
		/// <summary>
        /// suspensionreasondetails
        /// </summary>
		[DisplayName("suspensionreasondetails")]
		[AttributeLogicalName("suspensionreasondetails")]
		public string Suspensionreasondetails
		{	
			get { return GetAttributeValue<string>("suspensionreasondetails"); }
			set
			{ 
				if(Attributes.ContainsKey("suspensionreasondetails") && value == Suspensionreasondetails) return;
				SetAttributeValue("suspensionreasondetails", value);
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
				if(Attributes.ContainsKey("syncworkflowlogonfailure") && value == LogUponFailure) return;
				SetAttributeValue("syncworkflowlogonfailure", value);
			}
		}	
			
		/// <summary>
        /// throttlingbehavior
        /// </summary>
		[DisplayName("Throttling behavior type")]
		[AttributeLogicalName("throttlingbehavior")]
		public eThrottlingBehaviorType? ThrottlingBehaviorType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("throttlingbehavior");
				if (optionSetValue != null) return (eThrottlingBehaviorType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("throttlingbehavior") && value == ThrottlingBehaviorType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("throttlingbehavior", optionSetValue); 
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
				if(Attributes.ContainsKey("triggeroncreate") && value == TriggerOnCreate) return;
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
				if(Attributes.ContainsKey("triggerondelete") && value == TriggerOnDelete) return;
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
				if(Attributes.ContainsKey("triggeronupdateattributelist") && value == TriggerOnUpdateAttributeList) return;
				SetAttributeValue("triggeronupdateattributelist", value);
			}
		}	
			
		/// <summary>
        /// trustedaccess
        /// </summary>
		[DisplayName("Trusted Access")]
		[AttributeLogicalName("trustedaccess")]
		public bool? TrustedAccess
		{	
			get { return GetAttributeValue<bool?>("trustedaccess"); }
			set
			{ 
				if(Attributes.ContainsKey("trustedaccess") && value == TrustedAccess) return;
				SetAttributeValue("trustedaccess", value);
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
				if(Attributes.ContainsKey("type") && value == Type) return;

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
				if(Attributes.ContainsKey("uidata") && value == UIData) return;
				SetAttributeValue("uidata", value);
			}
		}	
			
		/// <summary>
        /// uiflowtype
        /// </summary>
		[DisplayName("Desktop Flow Type")]
		[AttributeLogicalName("uiflowtype")]
		public eUIFlowType? DesktopFlowType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("uiflowtype");
				if (optionSetValue != null) return (eUIFlowType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("uiflowtype") && value == DesktopFlowType) return;

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
				if(Attributes.ContainsKey("uniquename") && value == UniqueName) return;
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
				if(Attributes.ContainsKey("updatestage") && value == UpdateStage) return;

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
				if(Attributes.ContainsKey("versionnumber") && value == Versionnumber) return;
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
				if(Attributes.ContainsKey("workflowidunique") && value == WorkflowiduniqueId) return;
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
				if(Attributes.ContainsKey("xaml") && value == Xaml) return;
				SetAttributeValue("xaml", value);
			}
		}	
			
		#endregion	

		#region Relations
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
        /// 1:N Get entities for 'workflow_active_workflow'
        /// </summary>
		[RelationshipSchemaName("workflow_active_workflow")]
		public IEnumerable<Process> WorkflowActiveWorkflow
		{
			get { return GetRelatedEntities<Process>("workflow_active_workflow", null); }
			set { SetRelatedEntities("workflow_active_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Workflow_licenseentitledby'
        /// </summary>
		[RelationshipSchemaName("Workflow_licenseentitledby")]
		public IEnumerable<Process> WorkflowLicenseentitledby
		{
			get { return GetRelatedEntities<Process>("Workflow_licenseentitledby", null); }
			set { SetRelatedEntities("Workflow_licenseentitledby", null, value); }
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
		
			[Label("AI Flow")]
			[Description(@"")]
			AIFlow = 7, 
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
		
			[Label("Suspended")]
			[Description(@"")]
			Suspended = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 1, 
		
			[Label("Activated")]
			[Description(@"")]
			Activated_Inactive = 2, 
		
			[Label("CompanyDLPViolation")]
			[Description(@"")]
			CompanyDLPViolation = 3, 
		}
		
		public enum eThrottlingBehaviorType
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("TenantPool")]
			[Description(@"")]
			TenantPool = 1, 
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
		
		public enum eUIFlowType
		{	
		
			[Label("Recording")]
			[Description(@"")]
			Recording = 101, 
		
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

			/// <summary>billingcontext</summary>
			public const string BillingContext = "billingcontext";

			/// <summary>businessprocesstype</summary>
			public const string BusinessProcessType = "businessprocesstype";

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>clientdata</summary>
			public const string ClientData = "clientdata";

			/// <summary>clientdataiscompressed</summary>
			public const string ClientDataIsCompressed = "clientdataiscompressed";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>connectionreferences</summary>
			public const string ConnectionReferences = "connectionreferences";

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

			/// <summary>createmetadata</summary>
			public const string CreateMetadata = "createmetadata";

			/// <summary>createstage</summary>
			public const string CreateStage = "createstage";

			/// <summary>definition</summary>
			public const string Definition = "definition";

			/// <summary>deletestage</summary>
			public const string DeleteStage = "deletestage";

			/// <summary>dependencies</summary>
			public const string Dependencies = "dependencies";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>desktopflowmodules</summary>
			public const string DesktopFlowModules = "desktopflowmodules";

			/// <summary>dynamicssolutioncontext</summary>
			public const string DynamicsSolutionContext = "dynamicssolutioncontext";

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

			/// <summary>inputs</summary>
			public const string Inputs = "inputs";

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

			/// <summary>licenseentitledby</summary>
			public const string LicenseEntitledBy = "licenseentitledby";

			/// <summary>licenseentitledbyname</summary>
			public const string Licenseentitledbyname = "licenseentitledbyname";

			/// <summary>metadata</summary>
			public const string Metadata = "metadata";

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

			/// <summary>modifymetadata</summary>
			public const string ModifyMetadata = "modifymetadata";

			/// <summary>name</summary>
			public const string ProcessName = "name";

			/// <summary>ondemand</summary>
			public const string RunAsOnDemand = "ondemand";

			/// <summary>outputs</summary>
			public const string Outputs = "outputs";

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

			/// <summary>planverified</summary>
			public const string PlanVerified = "planverified";

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

			/// <summary>resourcecontainer</summary>
			public const string ResourceContainer = "resourcecontainer";

			/// <summary>resourceid</summary>
			public const string ResourceId = "resourceid";

			/// <summary>runas</summary>
			public const string RunAsUser = "runas";

			/// <summary>schemaversion</summary>
			public const string SchemaVersion = "schemaversion";

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

			/// <summary>suspensionreasondetails</summary>
			public const string Suspensionreasondetails = "suspensionreasondetails";

			/// <summary>syncworkflowlogonfailure</summary>
			public const string LogUponFailure = "syncworkflowlogonfailure";

			/// <summary>throttlingbehavior</summary>
			public const string ThrottlingBehaviorType = "throttlingbehavior";

			/// <summary>triggeroncreate</summary>
			public const string TriggerOnCreate = "triggeroncreate";

			/// <summary>triggerondelete</summary>
			public const string TriggerOnDelete = "triggerondelete";

			/// <summary>triggeronupdateattributelist</summary>
			public const string TriggerOnUpdateAttributeList = "triggeronupdateattributelist";

			/// <summary>trustedaccess</summary>
			public const string TrustedAccess = "trustedaccess";

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
			/// <summary>1:N lk_asyncoperation_workflowactivationid</summary>
			public const string LkAsyncoperationWorkflowactivationid = "lk_asyncoperation_workflowactivationid";

			/// <summary>1:N pw_workflow_pw_schedule_action</summary>
			public const string PwWorkflowPwScheduleAction = "pw_workflow_pw_schedule_action";

			/// <summary>1:N pw_workflow_pw_schedule_global_action</summary>
			public const string PwWorkflowPwScheduleGlobalAction = "pw_workflow_pw_schedule_global_action";

			/// <summary>1:N pw_workflow_pw_schedule_workflow</summary>
			public const string PwWorkflowPwScheduleWorkflow = "pw_workflow_pw_schedule_workflow";

			/// <summary>1:N workflow_active_workflow</summary>
			public const string WorkflowActiveWorkflow = "workflow_active_workflow";

			/// <summary>1:N Workflow_licenseentitledby</summary>
			public const string WorkflowLicenseentitledby = "Workflow_licenseentitledby";

			/// <summary>1:N workflow_parent_workflow</summary>
			public const string WorkflowParentWorkflow = "workflow_parent_workflow";

		}
		#endregion
	}
}

