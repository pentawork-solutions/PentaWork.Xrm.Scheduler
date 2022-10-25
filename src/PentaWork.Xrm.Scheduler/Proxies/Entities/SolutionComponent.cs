using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("solutioncomponent")]
	public sealed class SolutionComponent : Entity
	{	
		public static readonly int? EntityTypeCode = 7103;
		public new const string LogicalName = "solutioncomponent";
		public const string PrimaryIdAttribute = "solutioncomponentid";
		public const string PrimaryNameAttribute = "";
	
		public SolutionComponent() : base("solutioncomponent") { }

		#region Attributes
		/// <summary>
        /// componenttype
        /// </summary>
		[DisplayName("Object Type Code")]
		[AttributeLogicalName("componenttype")]
		public egComponentType? ObjectTypeCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componenttype");
				if (optionSetValue != null) return (egComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ObjectTypeCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componenttype", optionSetValue); 
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
        /// ismetadata
        /// </summary>
		[DisplayName("Is this component metadata")]
		[AttributeLogicalName("ismetadata")]
		public bool? IsThisComponentMetadata
		{	
			get { return GetAttributeValue<bool?>("ismetadata"); }
			set
			{ 
				if(value == IsThisComponentMetadata) return;
				SetAttributeValue("ismetadata", value);
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
        /// objectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("objectid")]
		public Guid RegardingId
		{	
			get { return GetAttributeValue<Guid>("objectid"); }
			set
			{ 
				if(value == RegardingId) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// rootcomponentbehavior
        /// </summary>
		[DisplayName("Root Component Behavior")]
		[AttributeLogicalName("rootcomponentbehavior")]
		public eIncludeBehavior? RootComponentBehavior
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("rootcomponentbehavior");
				if (optionSetValue != null) return (eIncludeBehavior)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RootComponentBehavior) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("rootcomponentbehavior", optionSetValue); 
			}
		}

		/// <summary>
        /// rootsolutioncomponentid
        /// </summary>
		[DisplayName("Root Solution Component ID")]
		[AttributeLogicalName("rootsolutioncomponentid")]
		public Guid RootSolutionComponentId
		{	
			get { return GetAttributeValue<Guid>("rootsolutioncomponentid"); }
			set
			{ 
				if(value == RootSolutionComponentId) return;
				SetAttributeValue("rootsolutioncomponentid", value);
			}
		}	
			
		/// <summary>
        /// solutioncomponentid
        /// </summary>
		[DisplayName("Solution Component Identifier")]
		[AttributeLogicalName("solutioncomponentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("solutioncomponentid", value); }
		}

							/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solutionid")]
		public EntityReference Solution
		{	
			get { return GetAttributeValue<EntityReference>("solutionid"); }
			set
			{ 
				if(value == Solution) return;
				SetAttributeValue("solutionid", value);
			}
		}	
			
		/// <summary>
        /// solutionidname
        /// </summary>
		[DisplayName("solutionidname")]
		[AttributeLogicalName("solutionidname")]
		public string Solutionidname
		{	
			get { return GetAttributeValue<string>("solutionidname"); }
			set
			{ 
				if(value == Solutionidname) return;
				SetAttributeValue("solutionidname", value);
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
        /// 1:N Get entities for 'solutioncomponent_parent_solutioncomponent'
        /// </summary>
		[RelationshipSchemaName("solutioncomponent_parent_solutioncomponent")]
		public IEnumerable<SolutionComponent> SolutioncomponentParentSolutioncomponent
		{
			get { return GetRelatedEntities<SolutionComponent>("solutioncomponent_parent_solutioncomponent", null); }
			set { SetRelatedEntities("solutioncomponent_parent_solutioncomponent", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egComponentType
		{	
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 1, 
		
			[Label("Attribute")]
			[Description(@"")]
			Attribute = 2, 
		
			[Label("Relationship")]
			[Description(@"")]
			Relationship = 3, 
		
			[Label("Attribute Picklist Value")]
			[Description(@"")]
			AttributePicklistValue = 4, 
		
			[Label("Attribute Lookup Value")]
			[Description(@"")]
			AttributeLookupValue = 5, 
		
			[Label("View Attribute")]
			[Description(@"")]
			ViewAttribute = 6, 
		
			[Label("Localized Label")]
			[Description(@"")]
			LocalizedLabel = 7, 
		
			[Label("Relationship Extra Condition")]
			[Description(@"")]
			RelationshipExtraCondition = 8, 
		
			[Label("Option Set")]
			[Description(@"")]
			OptionSet = 9, 
		
			[Label("Entity Relationship")]
			[Description(@"")]
			EntityRelationship = 10, 
		
			[Label("Entity Relationship Role")]
			[Description(@"")]
			EntityRelationshipRole = 11, 
		
			[Label("Entity Relationship Relationships")]
			[Description(@"")]
			EntityRelationshipRelationships = 12, 
		
			[Label("Managed Property")]
			[Description(@"")]
			ManagedProperty = 13, 
		
			[Label("Entity Key")]
			[Description(@"")]
			EntityKey = 14, 
		
			[Label("Privilege")]
			[Description(@"")]
			Privilege = 16, 
		
			[Label("PrivilegeObjectTypeCode")]
			[Description(@"")]
			PrivilegeObjectTypeCode = 17, 
		
			[Label("Role")]
			[Description(@"")]
			Role = 20, 
		
			[Label("Role Privilege")]
			[Description(@"")]
			RolePrivilege = 21, 
		
			[Label("Display String")]
			[Description(@"")]
			DisplayString = 22, 
		
			[Label("Display String Map")]
			[Description(@"")]
			DisplayStringMap = 23, 
		
			[Label("Form")]
			[Description(@"")]
			Form = 24, 
		
			[Label("Organization")]
			[Description(@"")]
			Organization = 25, 
		
			[Label("Saved Query")]
			[Description(@"")]
			SavedQuery = 26, 
		
			[Label("Workflow")]
			[Description(@"")]
			Workflow = 29, 
		
			[Label("Report")]
			[Description(@"")]
			Report = 31, 
		
			[Label("Report Entity")]
			[Description(@"")]
			ReportEntity = 32, 
		
			[Label("Report Category")]
			[Description(@"")]
			ReportCategory = 33, 
		
			[Label("Report Visibility")]
			[Description(@"")]
			ReportVisibility = 34, 
		
			[Label("Attachment")]
			[Description(@"")]
			Attachment = 35, 
		
			[Label("Email Template")]
			[Description(@"")]
			EmailTemplate = 36, 
		
			[Label("Contract Template")]
			[Description(@"")]
			ContractTemplate = 37, 
		
			[Label("KB Article Template")]
			[Description(@"")]
			KBArticleTemplate = 38, 
		
			[Label("Mail Merge Template")]
			[Description(@"")]
			MailMergeTemplate = 39, 
		
			[Label("Duplicate Rule")]
			[Description(@"")]
			DuplicateRule = 44, 
		
			[Label("Duplicate Rule Condition")]
			[Description(@"")]
			DuplicateRuleCondition = 45, 
		
			[Label("Entity Map")]
			[Description(@"")]
			EntityMap = 46, 
		
			[Label("Attribute Map")]
			[Description(@"")]
			AttributeMap = 47, 
		
			[Label("Ribbon Command")]
			[Description(@"")]
			RibbonCommand = 48, 
		
			[Label("Ribbon Context Group")]
			[Description(@"")]
			RibbonContextGroup = 49, 
		
			[Label("Ribbon Customization")]
			[Description(@"")]
			RibbonCustomization = 50, 
		
			[Label("Ribbon Rule")]
			[Description(@"")]
			RibbonRule = 52, 
		
			[Label("Ribbon Tab To Command Map")]
			[Description(@"")]
			RibbonTabToCommandMap = 53, 
		
			[Label("Ribbon Diff")]
			[Description(@"")]
			RibbonDiff = 55, 
		
			[Label("Saved Query Visualization")]
			[Description(@"")]
			SavedQueryVisualization = 59, 
		
			[Label("System Form")]
			[Description(@"")]
			SystemForm = 60, 
		
			[Label("Web Resource")]
			[Description(@"")]
			WebResource = 61, 
		
			[Label("Site Map")]
			[Description(@"")]
			SiteMap = 62, 
		
			[Label("Connection Role")]
			[Description(@"")]
			ConnectionRole = 63, 
		
			[Label("Complex Control")]
			[Description(@"")]
			ComplexControl = 64, 
		
			[Label("Field Security Profile")]
			[Description(@"")]
			FieldSecurityProfile = 70, 
		
			[Label("Field Permission")]
			[Description(@"")]
			FieldPermission = 71, 
		
			[Label("Plugin Type")]
			[Description(@"")]
			PluginType = 90, 
		
			[Label("Plugin Assembly")]
			[Description(@"")]
			PluginAssembly = 91, 
		
			[Label("SDK Message Processing Step")]
			[Description(@"")]
			SDKMessageProcessingStep = 92, 
		
			[Label("SDK Message Processing Step Image")]
			[Description(@"")]
			SDKMessageProcessingStepImage = 93, 
		
			[Label("Service Endpoint")]
			[Description(@"")]
			ServiceEndpoint = 95, 
		
			[Label("Routing Rule")]
			[Description(@"")]
			RoutingRule = 150, 
		
			[Label("Routing Rule Item")]
			[Description(@"")]
			RoutingRuleItem = 151, 
		
			[Label("SLA")]
			[Description(@"")]
			SLA = 152, 
		
			[Label("SLA Item")]
			[Description(@"")]
			SLAItem = 153, 
		
			[Label("Convert Rule")]
			[Description(@"")]
			ConvertRule = 154, 
		
			[Label("Convert Rule Item")]
			[Description(@"")]
			ConvertRuleItem = 155, 
		
			[Label("Hierarchy Rule")]
			[Description(@"")]
			HierarchyRule = 65, 
		
			[Label("Mobile Offline Profile")]
			[Description(@"")]
			MobileOfflineProfile = 161, 
		
			[Label("Mobile Offline Profile Item")]
			[Description(@"")]
			MobileOfflineProfileItem = 162, 
		
			[Label("Similarity Rule")]
			[Description(@"")]
			SimilarityRule = 165, 
		
			[Label("Custom Control")]
			[Description(@"")]
			CustomControl = 66, 
		
			[Label("Custom Control Default Config")]
			[Description(@"")]
			CustomControlDefaultConfig = 68, 
		
			[Label("Data Source Mapping")]
			[Description(@"")]
			DataSourceMapping = 166, 
		
			[Label("SDKMessage")]
			[Description(@"")]
			SDKMessage = 201, 
		
			[Label("SDKMessageFilter")]
			[Description(@"")]
			SDKMessageFilter = 202, 
		
			[Label("SdkMessagePair")]
			[Description(@"")]
			SdkMessagePair = 203, 
		
			[Label("SdkMessageRequest")]
			[Description(@"")]
			SdkMessageRequest = 204, 
		
			[Label("SdkMessageRequestField")]
			[Description(@"")]
			SdkMessageRequestField = 205, 
		
			[Label("SdkMessageResponse")]
			[Description(@"")]
			SdkMessageResponse = 206, 
		
			[Label("SdkMessageResponseField")]
			[Description(@"")]
			SdkMessageResponseField = 207, 
		
			[Label("WebWizard")]
			[Description(@"")]
			WebWizard = 210, 
		
			[Label("Index")]
			[Description(@"")]
			Index = 18, 
		
			[Label("Import Map")]
			[Description(@"")]
			ImportMap = 208, 
		
			[Label("Canvas App")]
			[Description(@"")]
			CanvasApp = 300, 
		
			[Label("Connector")]
			[Description(@"")]
			Connector = 371, 
		
			[Label("Connector")]
			[Description(@"")]
			Connector2 = 372, 
		
			[Label("Environment Variable Definition")]
			[Description(@"")]
			EnvironmentVariableDefinition = 380, 
		
			[Label("Environment Variable Value")]
			[Description(@"")]
			EnvironmentVariableValue = 381, 
		
			[Label("AI Project Type")]
			[Description(@"")]
			AIProjectType = 400, 
		
			[Label("AI Project")]
			[Description(@"")]
			AIProject = 401, 
		
			[Label("AI Configuration")]
			[Description(@"")]
			AIConfiguration = 402, 
		
			[Label("Entity Analytics Configuration")]
			[Description(@"")]
			EntityAnalyticsConfiguration = 430, 
		
			[Label("Attribute Image Configuration")]
			[Description(@"")]
			AttributeImageConfiguration = 431, 
		
			[Label("Entity Image Configuration")]
			[Description(@"")]
			EntityImageConfiguration = 432, 
		}
		
		public enum eIncludeBehavior
		{	
		
			[Label("Include Subcomponents")]
			[Description(@"")]
			IncludeSubcomponents = 0, 
		
			[Label("Do not include subcomponents")]
			[Description(@"")]
			DoNotIncludeSubcomponents = 1, 
		
			[Label("Include As Shell Only")]
			[Description(@"")]
			IncludeAsShellOnly = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componenttype</summary>
			public const string ObjectTypeCode = "componenttype";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>ismetadata</summary>
			public const string IsThisComponentMetadata = "ismetadata";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>objectid</summary>
			public const string RegardingId = "objectid";

			/// <summary>rootcomponentbehavior</summary>
			public const string RootComponentBehavior = "rootcomponentbehavior";

			/// <summary>rootsolutioncomponentid</summary>
			public const string RootSolutionComponentId = "rootsolutioncomponentid";

			/// <summary>solutioncomponentid</summary>
			public const string SolutionComponentIdentifierId = "solutioncomponentid";

			/// <summary>solutionid</summary>
			public const string Solution = "solutionid";

			/// <summary>solutionidname</summary>
			public const string Solutionidname = "solutionidname";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N solutioncomponent_parent_solutioncomponent</summary>
			public const string SolutioncomponentParentSolutioncomponent = "solutioncomponent_parent_solutioncomponent";

		}
		#endregion
	}
}

