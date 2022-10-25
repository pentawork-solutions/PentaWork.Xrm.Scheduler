using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("invaliddependency")]
	public sealed class InvalidDependency : Entity
	{	
		public static readonly int? EntityTypeCode = 7107;
		public new const string LogicalName = "invaliddependency";
		public const string PrimaryIdAttribute = "invaliddependencyid";
		public const string PrimaryNameAttribute = "";
	
		public InvalidDependency() : base("invaliddependency") { }

		#region Attributes
		/// <summary>
        /// existingcomponentid
        /// </summary>
		[DisplayName("Existing Object Id")]
		[AttributeLogicalName("existingcomponentid")]
		public Guid ExistingObjectId
		{	
			get { return GetAttributeValue<Guid>("existingcomponentid"); }
			set
			{ 
				if(value == ExistingObjectId) return;
				SetAttributeValue("existingcomponentid", value);
			}
		}	
			
		/// <summary>
        /// existingcomponenttype
        /// </summary>
		[DisplayName("Existing Object's Component Type")]
		[AttributeLogicalName("existingcomponenttype")]
		public egComponentType? ExistingObjectsComponentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("existingcomponenttype");
				if (optionSetValue != null) return (egComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExistingObjectsComponentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("existingcomponenttype", optionSetValue); 
			}
		}

		/// <summary>
        /// existingdependencytype
        /// </summary>
		[DisplayName("Weight")]
		[AttributeLogicalName("existingdependencytype")]
		public egDependencyType? Weight
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("existingdependencytype");
				if (optionSetValue != null) return (egDependencyType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Weight) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("existingdependencytype", optionSetValue); 
			}
		}

		/// <summary>
        /// invaliddependencyid
        /// </summary>
		[DisplayName("Invalid Dependency Identifier")]
		[AttributeLogicalName("invaliddependencyid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("invaliddependencyid", value); }
		}

							/// <summary>
        /// isexistingnoderequiredcomponent
        /// </summary>
		[DisplayName("Is this node the required component")]
		[AttributeLogicalName("isexistingnoderequiredcomponent")]
		public bool? IsThisNodeTheRequiredComponent
		{	
			get { return GetAttributeValue<bool?>("isexistingnoderequiredcomponent"); }
			set
			{ 
				if(value == IsThisNodeTheRequiredComponent) return;
				SetAttributeValue("isexistingnoderequiredcomponent", value);
			}
		}	
			
		/// <summary>
        /// missingcomponentid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("missingcomponentid")]
		public Guid RegardingId
		{	
			get { return GetAttributeValue<Guid>("missingcomponentid"); }
			set
			{ 
				if(value == RegardingId) return;
				SetAttributeValue("missingcomponentid", value);
			}
		}	
			
		/// <summary>
        /// missingcomponentinfo
        /// </summary>
		[DisplayName("missingcomponentinfo")]
		[AttributeLogicalName("missingcomponentinfo")]
		public string Missingcomponentinfo
		{	
			get { return GetAttributeValue<string>("missingcomponentinfo"); }
			set
			{ 
				if(value == Missingcomponentinfo) return;
				SetAttributeValue("missingcomponentinfo", value);
			}
		}	
			
		/// <summary>
        /// missingcomponentlookuptype
        /// </summary>
		[DisplayName("Lookup Type")]
		[AttributeLogicalName("missingcomponentlookuptype")]
		public int? LookupType
		{	
			get { return GetAttributeValue<int?>("missingcomponentlookuptype"); }
			set
			{ 
				if(value == LookupType) return;
				SetAttributeValue("missingcomponentlookuptype", value);
			}
		}	
			
		/// <summary>
        /// missingcomponenttype
        /// </summary>
		[DisplayName("Type Code")]
		[AttributeLogicalName("missingcomponenttype")]
		public egComponentType? TypeCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("missingcomponenttype");
				if (optionSetValue != null) return (egComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == TypeCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("missingcomponenttype", optionSetValue); 
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
			/// <summary>existingcomponentid</summary>
			public const string ExistingObjectId = "existingcomponentid";

			/// <summary>existingcomponenttype</summary>
			public const string ExistingObjectsComponentType = "existingcomponenttype";

			/// <summary>existingdependencytype</summary>
			public const string Weight = "existingdependencytype";

			/// <summary>invaliddependencyid</summary>
			public const string InvalidDependencyIdentifierId = "invaliddependencyid";

			/// <summary>isexistingnoderequiredcomponent</summary>
			public const string IsThisNodeTheRequiredComponent = "isexistingnoderequiredcomponent";

			/// <summary>missingcomponentid</summary>
			public const string RegardingId = "missingcomponentid";

			/// <summary>missingcomponentinfo</summary>
			public const string Missingcomponentinfo = "missingcomponentinfo";

			/// <summary>missingcomponentlookuptype</summary>
			public const string LookupType = "missingcomponentlookuptype";

			/// <summary>missingcomponenttype</summary>
			public const string TypeCode = "missingcomponenttype";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

