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
	[EntityLogicalName("sdkmessage")]
	public sealed class SdkMessage : Entity
	{	
		public static readonly int? EntityTypeCode = 4606;
		public new const string LogicalName = "sdkmessage";
		public const string PrimaryIdAttribute = "sdkmessageid";
		public const string PrimaryNameAttribute = "name";
	
		public SdkMessage() : base("sdkmessage") { }

		#region Attributes
		/// <summary>
        /// autotransact
        /// </summary>
		[DisplayName("Auto Transact")]
		[AttributeLogicalName("autotransact")]
		public bool? AutoTransact
		{	
			get { return GetAttributeValue<bool?>("autotransact"); }
			set
			{ 
				if(value == AutoTransact) return;
				SetAttributeValue("autotransact", value);
			}
		}	
			
		/// <summary>
        /// availability
        /// </summary>
		[DisplayName("Availability")]
		[AttributeLogicalName("availability")]
		public int? Availability
		{	
			get { return GetAttributeValue<int?>("availability"); }
			set
			{ 
				if(value == Availability) return;
				SetAttributeValue("availability", value);
			}
		}	
			
		/// <summary>
        /// categoryname
        /// </summary>
		[DisplayName("Category Name")]
		[AttributeLogicalName("categoryname")]
		public string CategoryName
		{	
			get { return GetAttributeValue<string>("categoryname"); }
			set
			{ 
				if(value == CategoryName) return;
				SetAttributeValue("categoryname", value);
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
        /// executeprivilegename
        /// </summary>
		[DisplayName("Execute Privilege Name")]
		[AttributeLogicalName("executeprivilegename")]
		public string ExecutePrivilegeName
		{	
			get { return GetAttributeValue<string>("executeprivilegename"); }
			set
			{ 
				if(value == ExecutePrivilegeName) return;
				SetAttributeValue("executeprivilegename", value);
			}
		}	
			
		/// <summary>
        /// expand
        /// </summary>
		[DisplayName("Expand")]
		[AttributeLogicalName("expand")]
		public bool? Expand
		{	
			get { return GetAttributeValue<bool?>("expand"); }
			set
			{ 
				if(value == Expand) return;
				SetAttributeValue("expand", value);
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
        /// isactive
        /// </summary>
		[DisplayName("Is Active")]
		[AttributeLogicalName("isactive")]
		public bool? IsActive
		{	
			get { return GetAttributeValue<bool?>("isactive"); }
			set
			{ 
				if(value == IsActive) return;
				SetAttributeValue("isactive", value);
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
        /// isprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("isprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(value == IsPrivate) return;
				SetAttributeValue("isprivate", value);
			}
		}	
			
		/// <summary>
        /// isreadonly
        /// </summary>
		[DisplayName("Intent")]
		[AttributeLogicalName("isreadonly")]
		public bool? Intent
		{	
			get { return GetAttributeValue<bool?>("isreadonly"); }
			set
			{ 
				if(value == Intent) return;
				SetAttributeValue("isreadonly", value);
			}
		}	
			
		/// <summary>
        /// isvalidforexecuteasync
        /// </summary>
		[DisplayName("Is Valid for Execute Async")]
		[AttributeLogicalName("isvalidforexecuteasync")]
		public bool? IsValidForExecuteAsync
		{	
			get { return GetAttributeValue<bool?>("isvalidforexecuteasync"); }
			set
			{ 
				if(value == IsValidForExecuteAsync) return;
				SetAttributeValue("isvalidforexecuteasync", value);
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
        /// sdkmessageid
        /// </summary>
		[DisplayName("sdkmessageid")]
		[AttributeLogicalName("sdkmessageid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("sdkmessageid", value); }
		}

							/// <summary>
        /// sdkmessageidunique
        /// </summary>
		[DisplayName("sdkmessageidunique")]
		[AttributeLogicalName("sdkmessageidunique")]
		public Guid SdkmessageiduniqueId
		{	
			get { return GetAttributeValue<Guid>("sdkmessageidunique"); }
			set
			{ 
				if(value == SdkmessageiduniqueId) return;
				SetAttributeValue("sdkmessageidunique", value);
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
        /// template
        /// </summary>
		[DisplayName("Template")]
		[AttributeLogicalName("template")]
		public bool? Template
		{	
			get { return GetAttributeValue<bool?>("template"); }
			set
			{ 
				if(value == Template) return;
				SetAttributeValue("template", value);
			}
		}	
			
		/// <summary>
        /// throttlesettings
        /// </summary>
		[DisplayName("Throttle Settings")]
		[AttributeLogicalName("throttlesettings")]
		public string ThrottleSettings
		{	
			get { return GetAttributeValue<string>("throttlesettings"); }
			set
			{ 
				if(value == ThrottleSettings) return;
				SetAttributeValue("throttlesettings", value);
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
        /// workflowsdkstepenabled
        /// </summary>
		[DisplayName("WorkflowSdkStepEnabled")]
		[AttributeLogicalName("workflowsdkstepenabled")]
		public bool? WorkflowSdkStepEnabled
		{	
			get { return GetAttributeValue<bool?>("workflowsdkstepenabled"); }
			set
			{ 
				if(value == WorkflowSdkStepEnabled) return;
				SetAttributeValue("workflowsdkstepenabled", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'sdkmessage_customapi'
        /// </summary>
		[RelationshipSchemaName("sdkmessage_customapi")]
		public IEnumerable<CustomAPI> SdkmessageCustomapi
		{
			get { return GetRelatedEntities<CustomAPI>("sdkmessage_customapi", null); }
			set { SetRelatedEntities("sdkmessage_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sdkmessageid_sdkmessagefilter'
        /// </summary>
		[RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
		public IEnumerable<SdkMessageFilter> SdkmessageidSdkmessagefilter
		{
			get { return GetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null); }
			set { SetRelatedEntities("sdkmessageid_sdkmessagefilter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sdkmessageid_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> SdkmessageidSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("sdkmessageid_sdkmessageprocessingstep", null, value); }
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
			/// <summary>autotransact</summary>
			public const string AutoTransact = "autotransact";

			/// <summary>availability</summary>
			public const string Availability = "availability";

			/// <summary>categoryname</summary>
			public const string CategoryName = "categoryname";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>executeprivilegename</summary>
			public const string ExecutePrivilegeName = "executeprivilegename";

			/// <summary>expand</summary>
			public const string Expand = "expand";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isactive</summary>
			public const string IsActive = "isactive";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

			/// <summary>isreadonly</summary>
			public const string Intent = "isreadonly";

			/// <summary>isvalidforexecuteasync</summary>
			public const string IsValidForExecuteAsync = "isvalidforexecuteasync";

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

			/// <summary>sdkmessageid</summary>
			public const string SdkmessageId = "sdkmessageid";

			/// <summary>sdkmessageidunique</summary>
			public const string SdkmessageiduniqueId = "sdkmessageidunique";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>template</summary>
			public const string Template = "template";

			/// <summary>throttlesettings</summary>
			public const string ThrottleSettings = "throttlesettings";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>workflowsdkstepenabled</summary>
			public const string WorkflowSdkStepEnabled = "workflowsdkstepenabled";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N sdkmessage_customapi</summary>
			public const string SdkmessageCustomapi = "sdkmessage_customapi";

			/// <summary>1:N sdkmessageid_sdkmessagefilter</summary>
			public const string SdkmessageidSdkmessagefilter = "sdkmessageid_sdkmessagefilter";

			/// <summary>1:N sdkmessageid_sdkmessageprocessingstep</summary>
			public const string SdkmessageidSdkmessageprocessingstep = "sdkmessageid_sdkmessageprocessingstep";

		}
		#endregion
	}
}

