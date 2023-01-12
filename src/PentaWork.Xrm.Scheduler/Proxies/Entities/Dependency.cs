using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("dependency")]
	public sealed class Dependency : Entity
	{	
		public static readonly int? EntityTypeCode = 7105;
		public new const string LogicalName = "dependency";
		public const string PrimaryIdAttribute = "dependencyid";
		public const string PrimaryNameAttribute = "";
	
		public Dependency() : base("dependency") { }

		#region Attributes
		/// <summary>
        /// dependencyid
        /// </summary>
		[DisplayName("Dependency Identifier")]
		[AttributeLogicalName("dependencyid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("dependencyid", value); }
		}

							/// <summary>
        /// dependencytype
        /// </summary>
		[DisplayName("Dependency Type")]
		[AttributeLogicalName("dependencytype")]
		public egDependencyType? DependencyType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("dependencytype");
				if (optionSetValue != null) return (egDependencyType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DependencyType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("dependencytype", optionSetValue); 
			}
		}

		/// <summary>
        /// dependentcomponentbasesolutionid
        /// </summary>
		[DisplayName("dependentcomponentbasesolutionid")]
		[AttributeLogicalName("dependentcomponentbasesolutionid")]
		public Guid DependentcomponentbasesolutionId
		{	
			get { return GetAttributeValue<Guid>("dependentcomponentbasesolutionid"); }
			set
			{ 
				if(value == DependentcomponentbasesolutionId) return;
				SetAttributeValue("dependentcomponentbasesolutionid", value);
			}
		}	
			
		/// <summary>
        /// dependentcomponentnodeid
        /// </summary>
		[DisplayName("Dependent Component")]
		[AttributeLogicalName("dependentcomponentnodeid")]
		public EntityReference DependentComponent
		{	
			get { return GetAttributeValue<EntityReference>("dependentcomponentnodeid"); }
			set
			{ 
				if(value == DependentComponent) return;
				SetAttributeValue("dependentcomponentnodeid", value);
			}
		}	
			
		/// <summary>
        /// dependentcomponentobjectid
        /// </summary>
		[DisplayName("dependentcomponentobjectid")]
		[AttributeLogicalName("dependentcomponentobjectid")]
		public Guid DependentcomponentobjectId
		{	
			get { return GetAttributeValue<Guid>("dependentcomponentobjectid"); }
			set
			{ 
				if(value == DependentcomponentobjectId) return;
				SetAttributeValue("dependentcomponentobjectid", value);
			}
		}	
			
		/// <summary>
        /// dependentcomponentparentid
        /// </summary>
		[DisplayName("dependentcomponentparentid")]
		[AttributeLogicalName("dependentcomponentparentid")]
		public Guid DependentcomponentparentId
		{	
			get { return GetAttributeValue<Guid>("dependentcomponentparentid"); }
			set
			{ 
				if(value == DependentcomponentparentId) return;
				SetAttributeValue("dependentcomponentparentid", value);
			}
		}	
			
		/// <summary>
        /// dependentcomponenttype
        /// </summary>
		[DisplayName("dependentcomponenttype")]
		[AttributeLogicalName("dependentcomponenttype")]
		public egComponentType? Dependentcomponenttype
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("dependentcomponenttype");
				if (optionSetValue != null) return (egComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Dependentcomponenttype) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("dependentcomponenttype", optionSetValue); 
			}
		}

		/// <summary>
        /// requiredcomponentbasesolutionid
        /// </summary>
		[DisplayName("requiredcomponentbasesolutionid")]
		[AttributeLogicalName("requiredcomponentbasesolutionid")]
		public Guid RequiredcomponentbasesolutionId
		{	
			get { return GetAttributeValue<Guid>("requiredcomponentbasesolutionid"); }
			set
			{ 
				if(value == RequiredcomponentbasesolutionId) return;
				SetAttributeValue("requiredcomponentbasesolutionid", value);
			}
		}	
			
		/// <summary>
        /// requiredcomponentintroducedversion
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("requiredcomponentintroducedversion")]
		[AttributeLogicalName("requiredcomponentintroducedversion")]
		public double? Requiredcomponentintroducedversion
		{	
			get { return GetAttributeValue<double?>("requiredcomponentintroducedversion"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 2);
				if(doubleValue == Requiredcomponentintroducedversion) return;
				SetAttributeValue("requiredcomponentintroducedversion", doubleValue);  
			}
		}

		/// <summary>
        /// requiredcomponentnodeid
        /// </summary>
		[DisplayName("Required Component")]
		[AttributeLogicalName("requiredcomponentnodeid")]
		public EntityReference RequiredComponent
		{	
			get { return GetAttributeValue<EntityReference>("requiredcomponentnodeid"); }
			set
			{ 
				if(value == RequiredComponent) return;
				SetAttributeValue("requiredcomponentnodeid", value);
			}
		}	
			
		/// <summary>
        /// requiredcomponentobjectid
        /// </summary>
		[DisplayName("requiredcomponentobjectid")]
		[AttributeLogicalName("requiredcomponentobjectid")]
		public Guid RequiredcomponentobjectId
		{	
			get { return GetAttributeValue<Guid>("requiredcomponentobjectid"); }
			set
			{ 
				if(value == RequiredcomponentobjectId) return;
				SetAttributeValue("requiredcomponentobjectid", value);
			}
		}	
			
		/// <summary>
        /// requiredcomponentparentid
        /// </summary>
		[DisplayName("requiredcomponentparentid")]
		[AttributeLogicalName("requiredcomponentparentid")]
		public Guid RequiredcomponentparentId
		{	
			get { return GetAttributeValue<Guid>("requiredcomponentparentid"); }
			set
			{ 
				if(value == RequiredcomponentparentId) return;
				SetAttributeValue("requiredcomponentparentid", value);
			}
		}	
			
		/// <summary>
        /// requiredcomponenttype
        /// </summary>
		[DisplayName("requiredcomponenttype")]
		[AttributeLogicalName("requiredcomponenttype")]
		public egComponentType? Requiredcomponenttype
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("requiredcomponenttype");
				if (optionSetValue != null) return (egComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Requiredcomponenttype) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("requiredcomponenttype", optionSetValue); 
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
		
		public enum egDependencyType
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Solution Internal")]
			[Description(@"")]
			SolutionInternal = 1, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 2, 
		
			[Label("Unpublished")]
			[Description(@"")]
			Unpublished = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>dependencyid</summary>
			public const string DependencyIdentifierId = "dependencyid";

			/// <summary>dependencytype</summary>
			public const string DependencyType = "dependencytype";

			/// <summary>dependentcomponentbasesolutionid</summary>
			public const string DependentcomponentbasesolutionId = "dependentcomponentbasesolutionid";

			/// <summary>dependentcomponentnodeid</summary>
			public const string DependentComponent = "dependentcomponentnodeid";

			/// <summary>dependentcomponentobjectid</summary>
			public const string DependentcomponentobjectId = "dependentcomponentobjectid";

			/// <summary>dependentcomponentparentid</summary>
			public const string DependentcomponentparentId = "dependentcomponentparentid";

			/// <summary>dependentcomponenttype</summary>
			public const string Dependentcomponenttype = "dependentcomponenttype";

			/// <summary>requiredcomponentbasesolutionid</summary>
			public const string RequiredcomponentbasesolutionId = "requiredcomponentbasesolutionid";

			/// <summary>requiredcomponentintroducedversion</summary>
			public const string Requiredcomponentintroducedversion = "requiredcomponentintroducedversion";

			/// <summary>requiredcomponentnodeid</summary>
			public const string RequiredComponent = "requiredcomponentnodeid";

			/// <summary>requiredcomponentobjectid</summary>
			public const string RequiredcomponentobjectId = "requiredcomponentobjectid";

			/// <summary>requiredcomponentparentid</summary>
			public const string RequiredcomponentparentId = "requiredcomponentparentid";

			/// <summary>requiredcomponenttype</summary>
			public const string Requiredcomponenttype = "requiredcomponenttype";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

