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
	[EntityLogicalName("msdyn_aiconfiguration")]
	public sealed class AIConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 402;
		public new const string LogicalName = "msdyn_aiconfiguration";
		public const string PrimaryIdAttribute = "msdyn_aiconfigurationid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIConfiguration() : base("msdyn_aiconfiguration") { }

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
        /// msdyn_aiconfigurationid
        /// </summary>
		[DisplayName("AIConfiguration")]
		[AttributeLogicalName("msdyn_aiconfigurationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aiconfigurationid", value); }
		}

							/// <summary>
        /// msdyn_aiconfigurationidunique
        /// </summary>
		[DisplayName("msdyn_aiconfigurationidunique")]
		[AttributeLogicalName("msdyn_aiconfigurationidunique")]
		public Guid MsdynAiconfigurationiduniqueId
		{	
			get { return GetAttributeValue<Guid>("msdyn_aiconfigurationidunique"); }
			set
			{ 
				if(value == MsdynAiconfigurationiduniqueId) return;
				SetAttributeValue("msdyn_aiconfigurationidunique", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aimodelid
        /// </summary>
		[DisplayName("AIModel")]
		[AttributeLogicalName("msdyn_aimodelid")]
		public EntityReference AIModel
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aimodelid"); }
			set
			{ 
				if(value == AIModel) return;
				SetAttributeValue("msdyn_aimodelid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aimodelidname
        /// </summary>
		[DisplayName("msdyn_aimodelidname")]
		[AttributeLogicalName("msdyn_aimodelidname")]
		public string MsdynAimodelidname
		{	
			get { return GetAttributeValue<string>("msdyn_aimodelidname"); }
			set
			{ 
				if(value == MsdynAimodelidname) return;
				SetAttributeValue("msdyn_aimodelidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_createdfromconfigurationid
        /// </summary>
		[DisplayName("CreatedFromConfigurationId")]
		[AttributeLogicalName("msdyn_createdfromconfigurationid")]
		public EntityReference CreatedFromConfigurationId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_createdfromconfigurationid"); }
			set
			{ 
				if(value == CreatedFromConfigurationId) return;
				SetAttributeValue("msdyn_createdfromconfigurationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_createdfromconfigurationidname
        /// </summary>
		[DisplayName("msdyn_createdfromconfigurationidname")]
		[AttributeLogicalName("msdyn_createdfromconfigurationidname")]
		public string MsdynCreatedfromconfigurationidname
		{	
			get { return GetAttributeValue<string>("msdyn_createdfromconfigurationidname"); }
			set
			{ 
				if(value == MsdynCreatedfromconfigurationidname) return;
				SetAttributeValue("msdyn_createdfromconfigurationidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_customconfiguration
        /// </summary>
		[DisplayName("CustomConfiguration")]
		[AttributeLogicalName("msdyn_customconfiguration")]
		public string CustomConfiguration
		{	
			get { return GetAttributeValue<string>("msdyn_customconfiguration"); }
			set
			{ 
				if(value == CustomConfiguration) return;
				SetAttributeValue("msdyn_customconfiguration", value);
			}
		}	
			
		/// <summary>
        /// msdyn_databinding
        /// </summary>
		[DisplayName("DataBinding")]
		[AttributeLogicalName("msdyn_databinding")]
		public string DataBinding
		{	
			get { return GetAttributeValue<string>("msdyn_databinding"); }
			set
			{ 
				if(value == DataBinding) return;
				SetAttributeValue("msdyn_databinding", value);
			}
		}	
			
		/// <summary>
        /// msdyn_lasterrors
        /// </summary>
		[DisplayName("LastErrors")]
		[AttributeLogicalName("msdyn_lasterrors")]
		public string LastErrors
		{	
			get { return GetAttributeValue<string>("msdyn_lasterrors"); }
			set
			{ 
				if(value == LastErrors) return;
				SetAttributeValue("msdyn_lasterrors", value);
			}
		}	
			
		/// <summary>
        /// msdyn_lasttrainorrundate
        /// </summary>
		[DisplayName("LastTrainOrRunDate")]
		[AttributeLogicalName("msdyn_lasttrainorrundate")]
		public DateTime? LastTrainOrRunDate
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_lasttrainorrundate"); }
			set
			{ 
				if(value == LastTrainOrRunDate) return;
				SetAttributeValue("msdyn_lasttrainorrundate", value);
			}
		}	
			
		/// <summary>
        /// msdyn_majoriterationnumber
        /// </summary>
		[DisplayName("MajorIterationNumber")]
		[AttributeLogicalName("msdyn_majoriterationnumber")]
		public int? MajorIterationNumber
		{	
			get { return GetAttributeValue<int?>("msdyn_majoriterationnumber"); }
			set
			{ 
				if(value == MajorIterationNumber) return;
				SetAttributeValue("msdyn_majoriterationnumber", value);
			}
		}	
			
		/// <summary>
        /// msdyn_minoriterationnumber
        /// </summary>
		[DisplayName("MinorIterationNumber")]
		[AttributeLogicalName("msdyn_minoriterationnumber")]
		public int? MinorIterationNumber
		{	
			get { return GetAttributeValue<int?>("msdyn_minoriterationnumber"); }
			set
			{ 
				if(value == MinorIterationNumber) return;
				SetAttributeValue("msdyn_minoriterationnumber", value);
			}
		}	
			
		/// <summary>
        /// msdyn_model_name
        /// </summary>
		[DisplayName("msdyn_model_name")]
		[AttributeLogicalName("msdyn_model_name")]
		public string MsdynModelName
		{	
			get { return GetAttributeValue<string>("msdyn_model_name"); }
			set
			{ 
				if(value == MsdynModelName) return;
				SetAttributeValue("msdyn_model_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modeldata
        /// </summary>
		[DisplayName("ModelData")]
		[AttributeLogicalName("msdyn_modeldata")]
		public string ModelData
		{	
			get { return GetAttributeValue<string>("msdyn_modeldata"); }
			set
			{ 
				if(value == ModelData) return;
				SetAttributeValue("msdyn_modeldata", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modelglobalexplainability
        /// </summary>
		[DisplayName("ModelGlobalExplainability")]
		[AttributeLogicalName("msdyn_modelglobalexplainability")]
		public string ModelGlobalExplainability
		{	
			get { return GetAttributeValue<string>("msdyn_modelglobalexplainability"); }
			set
			{ 
				if(value == ModelGlobalExplainability) return;
				SetAttributeValue("msdyn_modelglobalexplainability", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modelperformance
        /// </summary>
		[DisplayName("ModelPerformance")]
		[AttributeLogicalName("msdyn_modelperformance")]
		public string ModelPerformance
		{	
			get { return GetAttributeValue<string>("msdyn_modelperformance"); }
			set
			{ 
				if(value == ModelPerformance) return;
				SetAttributeValue("msdyn_modelperformance", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modelprovisioningmetadata
        /// </summary>
		[DisplayName("ModelProvisioningMetadata")]
		[AttributeLogicalName("msdyn_modelprovisioningmetadata")]
		public string ModelProvisioningMetadata
		{	
			get { return GetAttributeValue<string>("msdyn_modelprovisioningmetadata"); }
			set
			{ 
				if(value == ModelProvisioningMetadata) return;
				SetAttributeValue("msdyn_modelprovisioningmetadata", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modelprovisioningstatus
        /// </summary>
		[DisplayName("ModelProvisioningStatus")]
		[AttributeLogicalName("msdyn_modelprovisioningstatus")]
		public string ModelProvisioningStatus
		{	
			get { return GetAttributeValue<string>("msdyn_modelprovisioningstatus"); }
			set
			{ 
				if(value == ModelProvisioningStatus) return;
				SetAttributeValue("msdyn_modelprovisioningstatus", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modelrundataspecification
        /// </summary>
		[DisplayName("ModelRunDataSpecification")]
		[AttributeLogicalName("msdyn_modelrundataspecification")]
		public string ModelRunDataSpecification
		{	
			get { return GetAttributeValue<string>("msdyn_modelrundataspecification"); }
			set
			{ 
				if(value == ModelRunDataSpecification) return;
				SetAttributeValue("msdyn_modelrundataspecification", value);
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
        /// msdyn_resourceinfo
        /// </summary>
		[DisplayName("ResourceInfo")]
		[AttributeLogicalName("msdyn_resourceinfo")]
		public string ResourceInfo
		{	
			get { return GetAttributeValue<string>("msdyn_resourceinfo"); }
			set
			{ 
				if(value == ResourceInfo) return;
				SetAttributeValue("msdyn_resourceinfo", value);
			}
		}	
			
		/// <summary>
        /// msdyn_runconfiguration
        /// </summary>
		[DisplayName("RunConfiguration")]
		[AttributeLogicalName("msdyn_runconfiguration")]
		public string RunConfiguration
		{	
			get { return GetAttributeValue<string>("msdyn_runconfiguration"); }
			set
			{ 
				if(value == RunConfiguration) return;
				SetAttributeValue("msdyn_runconfiguration", value);
			}
		}	
			
		/// <summary>
        /// msdyn_schedulingoptions
        /// </summary>
		[DisplayName("SchedulingOptions")]
		[AttributeLogicalName("msdyn_schedulingoptions")]
		public string SchedulingOptions
		{	
			get { return GetAttributeValue<string>("msdyn_schedulingoptions"); }
			set
			{ 
				if(value == SchedulingOptions) return;
				SetAttributeValue("msdyn_schedulingoptions", value);
			}
		}	
			
		/// <summary>
        /// msdyn_templateversion
        /// </summary>
		[DisplayName("TemplateVersion")]
		[AttributeLogicalName("msdyn_templateversion")]
		public int? TemplateVersion
		{	
			get { return GetAttributeValue<int?>("msdyn_templateversion"); }
			set
			{ 
				if(value == TemplateVersion) return;
				SetAttributeValue("msdyn_templateversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_trainedmodelaiconfigurationpareid
        /// </summary>
		[DisplayName("TrainedModelAIConfigurationParent")]
		[AttributeLogicalName("msdyn_trainedmodelaiconfigurationpareid")]
		public EntityReference TrainedModelAIConfigurationParent
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_trainedmodelaiconfigurationpareid"); }
			set
			{ 
				if(value == TrainedModelAIConfigurationParent) return;
				SetAttributeValue("msdyn_trainedmodelaiconfigurationpareid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_trainedmodelaiconfigurationpareidname
        /// </summary>
		[DisplayName("msdyn_trainedmodelaiconfigurationpareidname")]
		[AttributeLogicalName("msdyn_trainedmodelaiconfigurationpareidname")]
		public string MsdynTrainedmodelaiconfigurationpareidname
		{	
			get { return GetAttributeValue<string>("msdyn_trainedmodelaiconfigurationpareidname"); }
			set
			{ 
				if(value == MsdynTrainedmodelaiconfigurationpareidname) return;
				SetAttributeValue("msdyn_trainedmodelaiconfigurationpareidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("msdyn_type")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_type");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_type", optionSetValue); 
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
        /// 1:N Get entities for 'msdyn_aiconfiguration_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAiconfigurationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aiconfiguration_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAiconfigurationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aiconfiguration_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_FileAttachments")]
		public IEnumerable<FileAttachment> MsdynAiconfigurationFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("msdyn_aiconfiguration_FileAttachments", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAiconfigurationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aiconfiguration_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_msdyn_aiconfiguration'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> MsdynAiconfigurationMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("msdyn_aiconfiguration_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_msdyn_aiconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_msdyn_aiodtrainingimage'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_msdyn_aiodtrainingimage")]
		public IEnumerable<AIObjectDetectionImageMapping> MsdynAiconfigurationMsdynAiodtrainingimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("msdyn_aiconfiguration_msdyn_aiodtrainingimage", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_msdyn_aiodtrainingimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAiconfigurationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aiconfiguration_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAiconfigurationProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aiconfiguration_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiconfiguration_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiconfiguration_SyncErrors")]
		public IEnumerable<SyncError> MsdynAiconfigurationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aiconfiguration_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aiconfiguration_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_createdfromconfiguration_msdyn_toconfiguration'
        /// </summary>
		[RelationshipSchemaName("msdyn_createdfromconfiguration_msdyn_toconfiguration")]
		public IEnumerable<AIConfiguration> MsdynCreatedfromconfigurationMsdynToconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("msdyn_createdfromconfiguration_msdyn_toconfiguration", null); }
			set { SetRelatedEntities("msdyn_createdfromconfiguration_msdyn_toconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId'
        /// </summary>
		[RelationshipSchemaName("msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId")]
		public IEnumerable<AIFormProcessingDocument> MsdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId", null); }
			set { SetRelatedEntities("msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'AIObjectDetectionLabel'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiconfiguration")]
		public IEnumerable<AIObjectDetectionLabel> MsdynAiodlabelMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("msdyn_aiodlabel_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_msdyn_aiconfiguration", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecuteTrain(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("Train");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteUnpublishAIConfiguration(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("UnpublishAIConfiguration");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteScheduleTraining(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("ScheduleTraining");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePublishAIConfiguration(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PublishAIConfiguration");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteQuickTest(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("QuickTest");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteUnscheduleTraining(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("UnscheduleTraining");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteCancelTraining(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("CancelTraining");
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
		
		public enum eType
		{	
		
			[Label("TrainingConfiguration")]
			[Description(@"")]
			TrainingConfiguration = 190690000, 
		
			[Label("RunConfiguration")]
			[Description(@"")]
			RunConfiguration = 190690001, 
		}
		
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("InProgress")]
			[Description(@"")]
			InProgress = 1, 
		
			[Label("Done")]
			[Description(@"")]
			Done = 2, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 0, 
		
			[Label("Training")]
			[Description(@"")]
			Training_Inactive = 1, 
		
			[Label("Cancelling")]
			[Description(@"")]
			Cancelling_Inactive = 2, 
		
			[Label("Publishing")]
			[Description(@"")]
			Publishing_Inactive = 3, 
		
			[Label("Unpublishing")]
			[Description(@"")]
			Unpublishing_Inactive = 4, 
		
			[Label("Deleting")]
			[Description(@"")]
			Deleting_Inactive = 5, 
		
			[Label("Trained")]
			[Description(@"")]
			Trained = 6, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 7, 
		
			[Label("Scheduled")]
			[Description(@"")]
			Scheduled = 8, 
		
			[Label("TrainFailed")]
			[Description(@"")]
			TrainFailed = 9, 
		
			[Label("PublishFailed")]
			[Description(@"")]
			PublishFailed = 10, 
		
			[Label("UnpublishFailed")]
			[Description(@"")]
			UnpublishFailed = 11, 
		
			[Label("CancelFailed")]
			[Description(@"")]
			CancelFailed = 12, 
		
			[Label("DeleteFailed")]
			[Description(@"")]
			DeleteFailed = 13, 
		
			[Label("UnsuccessfulTraining")]
			[Description(@"")]
			UnsuccessfulTraining = 14, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

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

			/// <summary>msdyn_aiconfigurationid</summary>
			public const string AIConfigurationId = "msdyn_aiconfigurationid";

			/// <summary>msdyn_aiconfigurationidunique</summary>
			public const string MsdynAiconfigurationiduniqueId = "msdyn_aiconfigurationidunique";

			/// <summary>msdyn_aimodelid</summary>
			public const string AIModel = "msdyn_aimodelid";

			/// <summary>msdyn_aimodelidname</summary>
			public const string MsdynAimodelidname = "msdyn_aimodelidname";

			/// <summary>msdyn_createdfromconfigurationid</summary>
			public const string CreatedFromConfigurationId = "msdyn_createdfromconfigurationid";

			/// <summary>msdyn_createdfromconfigurationidname</summary>
			public const string MsdynCreatedfromconfigurationidname = "msdyn_createdfromconfigurationidname";

			/// <summary>msdyn_customconfiguration</summary>
			public const string CustomConfiguration = "msdyn_customconfiguration";

			/// <summary>msdyn_databinding</summary>
			public const string DataBinding = "msdyn_databinding";

			/// <summary>msdyn_lasterrors</summary>
			public const string LastErrors = "msdyn_lasterrors";

			/// <summary>msdyn_lasttrainorrundate</summary>
			public const string LastTrainOrRunDate = "msdyn_lasttrainorrundate";

			/// <summary>msdyn_majoriterationnumber</summary>
			public const string MajorIterationNumber = "msdyn_majoriterationnumber";

			/// <summary>msdyn_minoriterationnumber</summary>
			public const string MinorIterationNumber = "msdyn_minoriterationnumber";

			/// <summary>msdyn_model_name</summary>
			public const string MsdynModelName = "msdyn_model_name";

			/// <summary>msdyn_modeldata</summary>
			public const string ModelData = "msdyn_modeldata";

			/// <summary>msdyn_modelglobalexplainability</summary>
			public const string ModelGlobalExplainability = "msdyn_modelglobalexplainability";

			/// <summary>msdyn_modelperformance</summary>
			public const string ModelPerformance = "msdyn_modelperformance";

			/// <summary>msdyn_modelprovisioningmetadata</summary>
			public const string ModelProvisioningMetadata = "msdyn_modelprovisioningmetadata";

			/// <summary>msdyn_modelprovisioningstatus</summary>
			public const string ModelProvisioningStatus = "msdyn_modelprovisioningstatus";

			/// <summary>msdyn_modelrundataspecification</summary>
			public const string ModelRunDataSpecification = "msdyn_modelrundataspecification";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_resourceinfo</summary>
			public const string ResourceInfo = "msdyn_resourceinfo";

			/// <summary>msdyn_runconfiguration</summary>
			public const string RunConfiguration = "msdyn_runconfiguration";

			/// <summary>msdyn_schedulingoptions</summary>
			public const string SchedulingOptions = "msdyn_schedulingoptions";

			/// <summary>msdyn_templateversion</summary>
			public const string TemplateVersion = "msdyn_templateversion";

			/// <summary>msdyn_trainedmodelaiconfigurationpareid</summary>
			public const string TrainedModelAIConfigurationParent = "msdyn_trainedmodelaiconfigurationpareid";

			/// <summary>msdyn_trainedmodelaiconfigurationpareidname</summary>
			public const string MsdynTrainedmodelaiconfigurationpareidname = "msdyn_trainedmodelaiconfigurationpareidname";

			/// <summary>msdyn_type</summary>
			public const string Type = "msdyn_type";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

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
			/// <summary>1:N msdyn_aiconfiguration_AsyncOperations</summary>
			public const string MsdynAiconfigurationAsyncOperations = "msdyn_aiconfiguration_AsyncOperations";

			/// <summary>1:N msdyn_aiconfiguration_BulkDeleteFailures</summary>
			public const string MsdynAiconfigurationBulkDeleteFailures = "msdyn_aiconfiguration_BulkDeleteFailures";

			/// <summary>1:N msdyn_aiconfiguration_FileAttachments</summary>
			public const string MsdynAiconfigurationFileAttachments = "msdyn_aiconfiguration_FileAttachments";

			/// <summary>1:N msdyn_aiconfiguration_MailboxTrackingFolders</summary>
			public const string MsdynAiconfigurationMailboxTrackingFolders = "msdyn_aiconfiguration_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aiconfiguration_msdyn_aiconfiguration</summary>
			public const string MsdynAiconfigurationMsdynAiconfiguration = "msdyn_aiconfiguration_msdyn_aiconfiguration";

			/// <summary>1:N msdyn_aiconfiguration_msdyn_aiodtrainingimage</summary>
			public const string MsdynAiconfigurationMsdynAiodtrainingimage = "msdyn_aiconfiguration_msdyn_aiodtrainingimage";

			/// <summary>1:N msdyn_aiconfiguration_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAiconfigurationPrincipalObjectAttributeAccesses = "msdyn_aiconfiguration_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aiconfiguration_ProcessSession</summary>
			public const string MsdynAiconfigurationProcessSession = "msdyn_aiconfiguration_ProcessSession";

			/// <summary>1:N msdyn_aiconfiguration_SyncErrors</summary>
			public const string MsdynAiconfigurationSyncErrors = "msdyn_aiconfiguration_SyncErrors";

			/// <summary>1:N msdyn_createdfromconfiguration_msdyn_toconfiguration</summary>
			public const string MsdynCreatedfromconfigurationMsdynToconfiguration = "msdyn_createdfromconfiguration_msdyn_toconfiguration";

			/// <summary>1:N msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId</summary>
			public const string MsdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId = "msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId";

			/// <summary>N:N msdyn_aiodlabel_msdyn_aiconfiguration</summary>
			public const string MsdynAiodlabelMsdynAiconfiguration = "msdyn_aiodlabel_msdyn_aiconfiguration";

		}
		#endregion
	}
}

