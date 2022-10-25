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
	[EntityLogicalName("msdyn_aimodel")]
	public sealed class AIModel : Entity
	{	
		public static readonly int? EntityTypeCode = 401;
		public new const string LogicalName = "msdyn_aimodel";
		public const string PrimaryIdAttribute = "msdyn_aimodelid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIModel() : base("msdyn_aimodel") { }

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
        /// msdyn_activerunconfigurationid
        /// </summary>
		[DisplayName("ActiveRunConfigurationId")]
		[AttributeLogicalName("msdyn_activerunconfigurationid")]
		public EntityReference ActiveRunConfigurationId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_activerunconfigurationid"); }
			set
			{ 
				if(value == ActiveRunConfigurationId) return;
				SetAttributeValue("msdyn_activerunconfigurationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aimodelid
        /// </summary>
		[DisplayName("AIModel")]
		[AttributeLogicalName("msdyn_aimodelid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aimodelid", value); }
		}

							/// <summary>
        /// msdyn_aimodelidunique
        /// </summary>
		[DisplayName("msdyn_aimodelidunique")]
		[AttributeLogicalName("msdyn_aimodelidunique")]
		public Guid MsdynAimodeliduniqueId
		{	
			get { return GetAttributeValue<Guid>("msdyn_aimodelidunique"); }
			set
			{ 
				if(value == MsdynAimodeliduniqueId) return;
				SetAttributeValue("msdyn_aimodelidunique", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modelcreationcontext
        /// </summary>
		[DisplayName("ModelCreationContext")]
		[AttributeLogicalName("msdyn_modelcreationcontext")]
		public string ModelCreationContext
		{	
			get { return GetAttributeValue<string>("msdyn_modelcreationcontext"); }
			set
			{ 
				if(value == ModelCreationContext) return;
				SetAttributeValue("msdyn_modelcreationcontext", value);
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
        /// msdyn_retrainworkflowid
        /// </summary>
		[DisplayName("RetrainWorkflowId")]
		[AttributeLogicalName("msdyn_retrainworkflowid")]
		public EntityReference RetrainWorkflowId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_retrainworkflowid"); }
			set
			{ 
				if(value == RetrainWorkflowId) return;
				SetAttributeValue("msdyn_retrainworkflowid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_retrainworkflowidname
        /// </summary>
		[DisplayName("msdyn_retrainworkflowidname")]
		[AttributeLogicalName("msdyn_retrainworkflowidname")]
		public string MsdynRetrainworkflowidname
		{	
			get { return GetAttributeValue<string>("msdyn_retrainworkflowidname"); }
			set
			{ 
				if(value == MsdynRetrainworkflowidname) return;
				SetAttributeValue("msdyn_retrainworkflowidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_scheduleinferenceworkflowid
        /// </summary>
		[DisplayName("ScheduleInferenceWorkflowId")]
		[AttributeLogicalName("msdyn_scheduleinferenceworkflowid")]
		public EntityReference ScheduleInferenceWorkflowId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_scheduleinferenceworkflowid"); }
			set
			{ 
				if(value == ScheduleInferenceWorkflowId) return;
				SetAttributeValue("msdyn_scheduleinferenceworkflowid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_scheduleinferenceworkflowidname
        /// </summary>
		[DisplayName("msdyn_scheduleinferenceworkflowidname")]
		[AttributeLogicalName("msdyn_scheduleinferenceworkflowidname")]
		public string MsdynScheduleinferenceworkflowidname
		{	
			get { return GetAttributeValue<string>("msdyn_scheduleinferenceworkflowidname"); }
			set
			{ 
				if(value == MsdynScheduleinferenceworkflowidname) return;
				SetAttributeValue("msdyn_scheduleinferenceworkflowidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sharewithorganizationoncreate
        /// </summary>
		[DisplayName("ShareWithOrganizationOnCreate")]
		[AttributeLogicalName("msdyn_sharewithorganizationoncreate")]
		public bool? ShareWithOrganizationOnCreate
		{	
			get { return GetAttributeValue<bool?>("msdyn_sharewithorganizationoncreate"); }
			set
			{ 
				if(value == ShareWithOrganizationOnCreate) return;
				SetAttributeValue("msdyn_sharewithorganizationoncreate", value);
			}
		}	
			
		/// <summary>
        /// msdyn_templateid
        /// </summary>
		[DisplayName("Template")]
		[AttributeLogicalName("msdyn_templateid")]
		public EntityReference Template
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_templateid"); }
			set
			{ 
				if(value == Template) return;
				SetAttributeValue("msdyn_templateid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_templateidname
        /// </summary>
		[DisplayName("msdyn_templateidname")]
		[AttributeLogicalName("msdyn_templateidname")]
		public string MsdynTemplateidname
		{	
			get { return GetAttributeValue<string>("msdyn_templateidname"); }
			set
			{ 
				if(value == MsdynTemplateidname) return;
				SetAttributeValue("msdyn_templateidname", value);
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
        /// 1:N Get entities for 'msdyn_AIBDatasetsContainer_msdyn_AIModelI'
        /// </summary>
		[RelationshipSchemaName("msdyn_AIBDatasetsContainer_msdyn_AIModelI")]
		public IEnumerable<AIBuilderDatasetsContainer> MsdynAIBDatasetsContainerMsdynAIModelI
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("msdyn_AIBDatasetsContainer_msdyn_AIModelI", null); }
			set { SetRelatedEntities("msdyn_AIBDatasetsContainer_msdyn_AIModelI", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_Annotations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_Annotations")]
		public IEnumerable<Note> MsdynAimodelAnnotations
		{
			get { return GetRelatedEntities<Note>("msdyn_aimodel_Annotations", null); }
			set { SetRelatedEntities("msdyn_aimodel_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAimodelAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aimodel_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aimodel_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAimodelBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aimodel_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aimodel_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAimodelMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aimodel_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aimodel_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_msdyn_aiconfiguration'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> MsdynAimodelMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("msdyn_aimodel_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("msdyn_aimodel_msdyn_aiconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAimodelPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aimodel_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aimodel_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAimodelProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aimodel_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aimodel_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aimodel_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aimodel_SyncErrors")]
		public IEnumerable<SyncError> MsdynAimodelSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aimodel_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aimodel_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecutePredictByReference(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PredictByReference");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteUnschedulePrediction(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("UnschedulePrediction");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteBatchPrediction(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("BatchPrediction");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePredictionSchema(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PredictionSchema");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePredict(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("Predict");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteSchedulePrediction(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("SchedulePrediction");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecuteScheduleRetrain(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("ScheduleRetrain");
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
		
		public enum eStatus
		{	
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 0, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Active = 0, 
		
			[Label("Active")]
			[Description(@"")]
			Active_Inactive = 1, 
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

			/// <summary>msdyn_activerunconfigurationid</summary>
			public const string ActiveRunConfigurationId = "msdyn_activerunconfigurationid";

			/// <summary>msdyn_aimodelid</summary>
			public const string AIModelId = "msdyn_aimodelid";

			/// <summary>msdyn_aimodelidunique</summary>
			public const string MsdynAimodeliduniqueId = "msdyn_aimodelidunique";

			/// <summary>msdyn_modelcreationcontext</summary>
			public const string ModelCreationContext = "msdyn_modelcreationcontext";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_retrainworkflowid</summary>
			public const string RetrainWorkflowId = "msdyn_retrainworkflowid";

			/// <summary>msdyn_retrainworkflowidname</summary>
			public const string MsdynRetrainworkflowidname = "msdyn_retrainworkflowidname";

			/// <summary>msdyn_scheduleinferenceworkflowid</summary>
			public const string ScheduleInferenceWorkflowId = "msdyn_scheduleinferenceworkflowid";

			/// <summary>msdyn_scheduleinferenceworkflowidname</summary>
			public const string MsdynScheduleinferenceworkflowidname = "msdyn_scheduleinferenceworkflowidname";

			/// <summary>msdyn_sharewithorganizationoncreate</summary>
			public const string ShareWithOrganizationOnCreate = "msdyn_sharewithorganizationoncreate";

			/// <summary>msdyn_templateid</summary>
			public const string Template = "msdyn_templateid";

			/// <summary>msdyn_templateidname</summary>
			public const string MsdynTemplateidname = "msdyn_templateidname";

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
			/// <summary>1:N msdyn_AIBDatasetsContainer_msdyn_AIModelI</summary>
			public const string MsdynAIBDatasetsContainerMsdynAIModelI = "msdyn_AIBDatasetsContainer_msdyn_AIModelI";

			/// <summary>1:N msdyn_aimodel_Annotations</summary>
			public const string MsdynAimodelAnnotations = "msdyn_aimodel_Annotations";

			/// <summary>1:N msdyn_aimodel_AsyncOperations</summary>
			public const string MsdynAimodelAsyncOperations = "msdyn_aimodel_AsyncOperations";

			/// <summary>1:N msdyn_aimodel_BulkDeleteFailures</summary>
			public const string MsdynAimodelBulkDeleteFailures = "msdyn_aimodel_BulkDeleteFailures";

			/// <summary>1:N msdyn_aimodel_MailboxTrackingFolders</summary>
			public const string MsdynAimodelMailboxTrackingFolders = "msdyn_aimodel_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aimodel_msdyn_aiconfiguration</summary>
			public const string MsdynAimodelMsdynAiconfiguration = "msdyn_aimodel_msdyn_aiconfiguration";

			/// <summary>1:N msdyn_aimodel_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAimodelPrincipalObjectAttributeAccesses = "msdyn_aimodel_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aimodel_ProcessSession</summary>
			public const string MsdynAimodelProcessSession = "msdyn_aimodel_ProcessSession";

			/// <summary>1:N msdyn_aimodel_SyncErrors</summary>
			public const string MsdynAimodelSyncErrors = "msdyn_aimodel_SyncErrors";

		}
		#endregion
	}
}

