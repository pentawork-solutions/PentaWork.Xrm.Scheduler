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
	[EntityLogicalName("sdkmessageprocessingstep")]
	public sealed class SdkMessageProcessingStep : Entity
	{	
		public static readonly int? EntityTypeCode = 4608;
		public new const string LogicalName = "sdkmessageprocessingstep";
		public const string PrimaryIdAttribute = "sdkmessageprocessingstepid";
		public const string PrimaryNameAttribute = "name";
	
		public SdkMessageProcessingStep() : base("sdkmessageprocessingstep") { }

		#region Attributes
		/// <summary>
        /// asyncautodelete
        /// </summary>
		[DisplayName("Asynchronous Automatic Delete")]
		[AttributeLogicalName("asyncautodelete")]
		public bool? AsynchronousAutomaticDelete
		{	
			get { return GetAttributeValue<bool?>("asyncautodelete"); }
			set
			{ 
				if(value == AsynchronousAutomaticDelete) return;
				SetAttributeValue("asyncautodelete", value);
			}
		}	
			
		/// <summary>
        /// canusereadonlyconnection
        /// </summary>
		[DisplayName("Intent")]
		[AttributeLogicalName("canusereadonlyconnection")]
		public bool? Intent
		{	
			get { return GetAttributeValue<bool?>("canusereadonlyconnection"); }
			set
			{ 
				if(value == Intent) return;
				SetAttributeValue("canusereadonlyconnection", value);
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
        /// configuration
        /// </summary>
		[DisplayName("Configuration")]
		[AttributeLogicalName("configuration")]
		public string Configuration
		{	
			get { return GetAttributeValue<string>("configuration"); }
			set
			{ 
				if(value == Configuration) return;
				SetAttributeValue("configuration", value);
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
        /// customizationlevel
        /// </summary>
		[DisplayName("customizationlevel")]
		[AttributeLogicalName("customizationlevel")]
		public int? Customizationlevel
		{	
			get { return GetAttributeValue<int?>("customizationlevel"); }
			set
			{ 
				if(value == Customizationlevel) return;
				SetAttributeValue("customizationlevel", value);
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
        /// eventexpander
        /// </summary>
		[DisplayName("EventExpander")]
		[AttributeLogicalName("eventexpander")]
		public string EventExpander
		{	
			get { return GetAttributeValue<string>("eventexpander"); }
			set
			{ 
				if(value == EventExpander) return;
				SetAttributeValue("eventexpander", value);
			}
		}	
			
		/// <summary>
        /// eventhandler
        /// </summary>
		[DisplayName("Event Handler")]
		[AttributeLogicalName("eventhandler")]
		public EntityReference EventHandler
		{	
			get { return GetAttributeValue<EntityReference>("eventhandler"); }
			set
			{ 
				if(value == EventHandler) return;
				SetAttributeValue("eventhandler", value);
			}
		}	
			
		/// <summary>
        /// eventhandlername
        /// </summary>
		[DisplayName("eventhandlername")]
		[AttributeLogicalName("eventhandlername")]
		public string Eventhandlername
		{	
			get { return GetAttributeValue<string>("eventhandlername"); }
			set
			{ 
				if(value == Eventhandlername) return;
				SetAttributeValue("eventhandlername", value);
			}
		}	
			
		/// <summary>
        /// eventhandlertypecode
        /// </summary>
		[DisplayName("eventhandlertypecode")]
		[AttributeLogicalName("eventhandlertypecode")]
		public string Eventhandlertypecode
		{	
			get { return GetAttributeValue<string>("eventhandlertypecode"); }
			set
			{ 
				if(value == Eventhandlertypecode) return;
				SetAttributeValue("eventhandlertypecode", value);
			}
		}	
			
		/// <summary>
        /// filteringattributes
        /// </summary>
		[DisplayName("Filtering Attributes")]
		[AttributeLogicalName("filteringattributes")]
		public string FilteringAttributes
		{	
			get { return GetAttributeValue<string>("filteringattributes"); }
			set
			{ 
				if(value == FilteringAttributes) return;
				SetAttributeValue("filteringattributes", value);
			}
		}	
			
		/// <summary>
        /// impersonatinguserid
        /// </summary>
		[DisplayName("Impersonating User")]
		[AttributeLogicalName("impersonatinguserid")]
		public EntityReference ImpersonatingUser
		{	
			get { return GetAttributeValue<EntityReference>("impersonatinguserid"); }
			set
			{ 
				if(value == ImpersonatingUser) return;
				SetAttributeValue("impersonatinguserid", value);
			}
		}	
			
		/// <summary>
        /// impersonatinguseridname
        /// </summary>
		[DisplayName("impersonatinguseridname")]
		[AttributeLogicalName("impersonatinguseridname")]
		public string Impersonatinguseridname
		{	
			get { return GetAttributeValue<string>("impersonatinguseridname"); }
			set
			{ 
				if(value == Impersonatinguseridname) return;
				SetAttributeValue("impersonatinguseridname", value);
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
        /// invocationsource
        /// </summary>
		[DisplayName("Invocation Source")]
		[AttributeLogicalName("invocationsource")]
		public eInvocationSource? InvocationSource
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("invocationsource");
				if (optionSetValue != null) return (eInvocationSource)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InvocationSource) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("invocationsource", optionSetValue); 
			}
		}

		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("State")]
		[AttributeLogicalName("ismanaged")]
		public bool? State
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == State) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// mode
        /// </summary>
		[DisplayName("Execution Mode")]
		[AttributeLogicalName("mode")]
		public eMode? ExecutionMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("mode");
				if (optionSetValue != null) return (eMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExecutionMode) return;

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
        /// organizationid
        /// </summary>
		[DisplayName("organizationid")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organizationid
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organizationid) return;
				SetAttributeValue("organizationid", value);
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
        /// plugintypeid
        /// </summary>
		[DisplayName("Plug-In Type")]
		[AttributeLogicalName("plugintypeid")]
		public EntityReference PlugInType
		{	
			get { return GetAttributeValue<EntityReference>("plugintypeid"); }
			set
			{ 
				if(value == PlugInType) return;
				SetAttributeValue("plugintypeid", value);
			}
		}	
			
		/// <summary>
        /// plugintypeidname
        /// </summary>
		[DisplayName("plugintypeidname")]
		[AttributeLogicalName("plugintypeidname")]
		public string Plugintypeidname
		{	
			get { return GetAttributeValue<string>("plugintypeidname"); }
			set
			{ 
				if(value == Plugintypeidname) return;
				SetAttributeValue("plugintypeidname", value);
			}
		}	
			
		/// <summary>
        /// rank
        /// </summary>
		[DisplayName("Execution Order")]
		[AttributeLogicalName("rank")]
		public int? ExecutionOrder
		{	
			get { return GetAttributeValue<int?>("rank"); }
			set
			{ 
				if(value == ExecutionOrder) return;
				SetAttributeValue("rank", value);
			}
		}	
			
		/// <summary>
        /// sdkmessagefilterid
        /// </summary>
		[DisplayName("SdkMessage Filter")]
		[AttributeLogicalName("sdkmessagefilterid")]
		public EntityReference SdkMessageFilter
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessagefilterid"); }
			set
			{ 
				if(value == SdkMessageFilter) return;
				SetAttributeValue("sdkmessagefilterid", value);
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
        /// sdkmessageidname
        /// </summary>
		[DisplayName("sdkmessageidname")]
		[AttributeLogicalName("sdkmessageidname")]
		public string Sdkmessageidname
		{	
			get { return GetAttributeValue<string>("sdkmessageidname"); }
			set
			{ 
				if(value == Sdkmessageidname) return;
				SetAttributeValue("sdkmessageidname", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageprocessingstepid
        /// </summary>
		[DisplayName("sdkmessageprocessingstepid")]
		[AttributeLogicalName("sdkmessageprocessingstepid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("sdkmessageprocessingstepid", value); }
		}

							/// <summary>
        /// sdkmessageprocessingstepidunique
        /// </summary>
		[DisplayName("sdkmessageprocessingstepidunique")]
		[AttributeLogicalName("sdkmessageprocessingstepidunique")]
		public Guid SdkmessageprocessingstepiduniqueId
		{	
			get { return GetAttributeValue<Guid>("sdkmessageprocessingstepidunique"); }
			set
			{ 
				if(value == SdkmessageprocessingstepiduniqueId) return;
				SetAttributeValue("sdkmessageprocessingstepidunique", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageprocessingstepsecureconfigid
        /// </summary>
		[DisplayName("SDK Message Processing Step Secure Configuration")]
		[AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
		public EntityReference SDKMessageProcessingStepSecureConfiguration
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessageprocessingstepsecureconfigid"); }
			set
			{ 
				if(value == SDKMessageProcessingStepSecureConfiguration) return;
				SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
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
        /// stage
        /// </summary>
		[DisplayName("Execution Stage")]
		[AttributeLogicalName("stage")]
		public eStage? ExecutionStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("stage");
				if (optionSetValue != null) return (eStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExecutionStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("stage", optionSetValue); 
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
        /// supporteddeployment
        /// </summary>
		[DisplayName("Deployment")]
		[AttributeLogicalName("supporteddeployment")]
		public eSupportedDeployment? Deployment
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("supporteddeployment");
				if (optionSetValue != null) return (eSupportedDeployment)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Deployment) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("supporteddeployment", optionSetValue); 
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
        /// 1:N Get entities for 'SdkMessageProcessingStep_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
		public IEnumerable<SystemJob> SdkMessageProcessingStepAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SdkMessageProcessingStep_AsyncOperations", null); }
			set { SetRelatedEntities("SdkMessageProcessingStep_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sdkmessageprocessingstepid_sdkmessageprocessingstepimage'
        /// </summary>
		[RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
		public IEnumerable<SdkMessageProcessingStepImage> SdkmessageprocessingstepidSdkmessageprocessingstepimage
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null); }
			set { SetRelatedEntities("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value); }
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
		
		public enum eInvocationSource
		{	
		
			[Label("Internal")]
			[Description(@"")]
			Internal = -1, 
		
			[Label("Parent")]
			[Description(@"")]
			Parent = 0, 
		
			[Label("Child")]
			[Description(@"")]
			Child = 1, 
		}
		
		public enum eMode
		{	
		
			[Label("Synchronous")]
			[Description(@"")]
			Synchronous = 0, 
		
			[Label("Asynchronous")]
			[Description(@"")]
			Asynchronous = 1, 
		}
		
		public enum eStage
		{	
		
			[Label("Initial Pre-operation (For internal use only)")]
			[Description(@"")]
			InitialPreoperationForInternalUseOnly = 5, 
		
			[Label("Pre-validation")]
			[Description(@"")]
			Prevalidation = 10, 
		
			[Label("Internal Pre-operation Before External Plugins (For internal use only)")]
			[Description(@"")]
			InternalPreoperationBeforeExternalPluginsForInternalUseOnly = 15, 
		
			[Label("Pre-operation")]
			[Description(@"")]
			Preoperation = 20, 
		
			[Label("Internal Pre-operation After External Plugins (For internal use only)")]
			[Description(@"")]
			InternalPreoperationAfterExternalPluginsForInternalUseOnly = 25, 
		
			[Label("Main Operation (For internal use only)")]
			[Description(@"")]
			MainOperationForInternalUseOnly = 30, 
		
			[Label("Internal Post-operation Before External Plugins (For internal use only)")]
			[Description(@"")]
			InternalPostoperationBeforeExternalPluginsForInternalUseOnly = 35, 
		
			[Label("Post-operation")]
			[Description(@"")]
			Postoperation = 40, 
		
			[Label("Internal Post-operation After External Plugins (For internal use only)")]
			[Description(@"")]
			InternalPostoperationAfterExternalPluginsForInternalUseOnly = 45, 
		
			[Label("Post-operation (Deprecated)")]
			[Description(@"")]
			PostoperationDeprecated = 50, 
		
			[Label("Final Post-operation (For internal use only)")]
			[Description(@"")]
			FinalPostoperationForInternalUseOnly = 55, 
		
			[Label("Pre-Commit stage fired before transaction commit (For internal use only)")]
			[Description(@"")]
			PreCommitStageFiredBeforeTransactionCommitForInternalUseOnly = 80, 
		
			[Label("Post-Commit stage fired after transaction commit (For internal use only)")]
			[Description(@"")]
			PostCommitStageFiredAfterTransactionCommitForInternalUseOnly = 90, 
		}
		
		public enum eStatus
		{	
		
			[Label("Enabled")]
			[Description(@"")]
			Enabled = 0, 
		
			[Label("Disabled")]
			[Description(@"")]
			Disabled = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Enabled")]
			[Description(@"")]
			Enabled_Active = 1, 
		
			[Label("Disabled")]
			[Description(@"")]
			Disabled_Inactive = 2, 
		}
		
		public enum eSupportedDeployment
		{	
		
			[Label("Server Only")]
			[Description(@"")]
			ServerOnly = 0, 
		
			[Label("Microsoft Dynamics 365 Client for Outlook Only")]
			[Description(@"")]
			MicrosoftDynamics365ClientForOutlookOnly = 1, 
		
			[Label("Both")]
			[Description(@"")]
			Both = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>asyncautodelete</summary>
			public const string AsynchronousAutomaticDelete = "asyncautodelete";

			/// <summary>canusereadonlyconnection</summary>
			public const string Intent = "canusereadonlyconnection";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>configuration</summary>
			public const string Configuration = "configuration";

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

			/// <summary>customizationlevel</summary>
			public const string Customizationlevel = "customizationlevel";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>eventexpander</summary>
			public const string EventExpander = "eventexpander";

			/// <summary>eventhandler</summary>
			public const string EventHandler = "eventhandler";

			/// <summary>eventhandlername</summary>
			public const string Eventhandlername = "eventhandlername";

			/// <summary>eventhandlertypecode</summary>
			public const string Eventhandlertypecode = "eventhandlertypecode";

			/// <summary>filteringattributes</summary>
			public const string FilteringAttributes = "filteringattributes";

			/// <summary>impersonatinguserid</summary>
			public const string ImpersonatingUser = "impersonatinguserid";

			/// <summary>impersonatinguseridname</summary>
			public const string Impersonatinguseridname = "impersonatinguseridname";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>invocationsource</summary>
			public const string InvocationSource = "invocationsource";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>mode</summary>
			public const string ExecutionMode = "mode";

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

			/// <summary>organizationid</summary>
			public const string Organizationid = "organizationid";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>plugintypeid</summary>
			public const string PlugInType = "plugintypeid";

			/// <summary>plugintypeidname</summary>
			public const string Plugintypeidname = "plugintypeidname";

			/// <summary>rank</summary>
			public const string ExecutionOrder = "rank";

			/// <summary>sdkmessagefilterid</summary>
			public const string SdkMessageFilter = "sdkmessagefilterid";

			/// <summary>sdkmessageid</summary>
			public const string SDKMessage = "sdkmessageid";

			/// <summary>sdkmessageidname</summary>
			public const string Sdkmessageidname = "sdkmessageidname";

			/// <summary>sdkmessageprocessingstepid</summary>
			public const string SdkmessageprocessingstepId = "sdkmessageprocessingstepid";

			/// <summary>sdkmessageprocessingstepidunique</summary>
			public const string SdkmessageprocessingstepiduniqueId = "sdkmessageprocessingstepidunique";

			/// <summary>sdkmessageprocessingstepsecureconfigid</summary>
			public const string SDKMessageProcessingStepSecureConfiguration = "sdkmessageprocessingstepsecureconfigid";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>stage</summary>
			public const string ExecutionStage = "stage";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supporteddeployment</summary>
			public const string Deployment = "supporteddeployment";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N SdkMessageProcessingStep_AsyncOperations</summary>
			public const string SdkMessageProcessingStepAsyncOperations = "SdkMessageProcessingStep_AsyncOperations";

			/// <summary>1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage</summary>
			public const string SdkmessageprocessingstepidSdkmessageprocessingstepimage = "sdkmessageprocessingstepid_sdkmessageprocessingstepimage";

		}
		#endregion
	}
}

