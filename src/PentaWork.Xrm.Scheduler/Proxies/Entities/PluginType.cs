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
	[EntityLogicalName("plugintype")]
	public sealed class PluginType : Entity
	{	
		public static readonly int? EntityTypeCode = 4602;
		public new const string LogicalName = "plugintype";
		public const string PrimaryIdAttribute = "plugintypeid";
		public const string PrimaryNameAttribute = "name";
	
		public PluginType() : base("plugintype") { }

		#region Attributes
		/// <summary>
        /// assemblyname
        /// </summary>
		[DisplayName("Assembly Name")]
		[AttributeLogicalName("assemblyname")]
		public string AssemblyName
		{	
			get { return GetAttributeValue<string>("assemblyname"); }
			set
			{ 
				if(value == AssemblyName) return;
				SetAttributeValue("assemblyname", value);
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
        /// culture
        /// </summary>
		[DisplayName("Culture")]
		[AttributeLogicalName("culture")]
		public string Culture
		{	
			get { return GetAttributeValue<string>("culture"); }
			set
			{ 
				if(value == Culture) return;
				SetAttributeValue("culture", value);
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
        /// customworkflowactivityinfo
        /// </summary>
		[DisplayName("Custom Workflow Activity Info")]
		[AttributeLogicalName("customworkflowactivityinfo")]
		public string CustomWorkflowActivityInfo
		{	
			get { return GetAttributeValue<string>("customworkflowactivityinfo"); }
			set
			{ 
				if(value == CustomWorkflowActivityInfo) return;
				SetAttributeValue("customworkflowactivityinfo", value);
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
        /// friendlyname
        /// </summary>
		[DisplayName("Display Name")]
		[AttributeLogicalName("friendlyname")]
		public string DisplayName
		{	
			get { return GetAttributeValue<string>("friendlyname"); }
			set
			{ 
				if(value == DisplayName) return;
				SetAttributeValue("friendlyname", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("ismanaged")]
		[AttributeLogicalName("ismanaged")]
		public bool? Ismanaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == Ismanaged) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// isworkflowactivity
        /// </summary>
		[DisplayName("Is Workflow Activity")]
		[AttributeLogicalName("isworkflowactivity")]
		public bool? IsWorkflowActivity
		{	
			get { return GetAttributeValue<bool?>("isworkflowactivity"); }
			set
			{ 
				if(value == IsWorkflowActivity) return;
				SetAttributeValue("isworkflowactivity", value);
			}
		}	
			
		/// <summary>
        /// major
        /// </summary>
		[DisplayName("Version major")]
		[AttributeLogicalName("major")]
		public int? VersionMajor
		{	
			get { return GetAttributeValue<int?>("major"); }
			set
			{ 
				if(value == VersionMajor) return;
				SetAttributeValue("major", value);
			}
		}	
			
		/// <summary>
        /// minor
        /// </summary>
		[DisplayName("Version minor")]
		[AttributeLogicalName("minor")]
		public int? VersionMinor
		{	
			get { return GetAttributeValue<int?>("minor"); }
			set
			{ 
				if(value == VersionMinor) return;
				SetAttributeValue("minor", value);
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
        /// pluginassemblyid
        /// </summary>
		[DisplayName("Plugin Assembly")]
		[AttributeLogicalName("pluginassemblyid")]
		public EntityReference PluginAssembly
		{	
			get { return GetAttributeValue<EntityReference>("pluginassemblyid"); }
			set
			{ 
				if(value == PluginAssembly) return;
				SetAttributeValue("pluginassemblyid", value);
			}
		}	
			
		/// <summary>
        /// pluginassemblyidname
        /// </summary>
		[DisplayName("pluginassemblyidname")]
		[AttributeLogicalName("pluginassemblyidname")]
		public string Pluginassemblyidname
		{	
			get { return GetAttributeValue<string>("pluginassemblyidname"); }
			set
			{ 
				if(value == Pluginassemblyidname) return;
				SetAttributeValue("pluginassemblyidname", value);
			}
		}	
			
		/// <summary>
        /// plugintypeid
        /// </summary>
		[DisplayName("Plug-in Type")]
		[AttributeLogicalName("plugintypeid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("plugintypeid", value); }
		}

							/// <summary>
        /// plugintypeidunique
        /// </summary>
		[DisplayName("plugintypeidunique")]
		[AttributeLogicalName("plugintypeidunique")]
		public Guid PlugintypeiduniqueId
		{	
			get { return GetAttributeValue<Guid>("plugintypeidunique"); }
			set
			{ 
				if(value == PlugintypeiduniqueId) return;
				SetAttributeValue("plugintypeidunique", value);
			}
		}	
			
		/// <summary>
        /// publickeytoken
        /// </summary>
		[DisplayName("Public Key Token")]
		[AttributeLogicalName("publickeytoken")]
		public string PublicKeyToken
		{	
			get { return GetAttributeValue<string>("publickeytoken"); }
			set
			{ 
				if(value == PublicKeyToken) return;
				SetAttributeValue("publickeytoken", value);
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
        /// typename
        /// </summary>
		[DisplayName("Type Name")]
		[AttributeLogicalName("typename")]
		public string TypeName
		{	
			get { return GetAttributeValue<string>("typename"); }
			set
			{ 
				if(value == TypeName) return;
				SetAttributeValue("typename", value);
			}
		}	
			
		/// <summary>
        /// version
        /// </summary>
		[DisplayName("Version")]
		[AttributeLogicalName("version")]
		public string Version
		{	
			get { return GetAttributeValue<string>("version"); }
			set
			{ 
				if(value == Version) return;
				SetAttributeValue("version", value);
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
        /// workflowactivitygroupname
        /// </summary>
		[DisplayName("Workflow Activity Group Name")]
		[AttributeLogicalName("workflowactivitygroupname")]
		public string WorkflowActivityGroupName
		{	
			get { return GetAttributeValue<string>("workflowactivitygroupname"); }
			set
			{ 
				if(value == WorkflowActivityGroupName) return;
				SetAttributeValue("workflowactivitygroupname", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'plugin_type_service'
        /// </summary>
		[RelationshipSchemaName("plugin_type_service")]
		public IEnumerable<Service> PluginTypeService
		{
			get { return GetRelatedEntities<Service>("plugin_type_service", null); }
			set { SetRelatedEntities("plugin_type_service", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'plugintype_customapi'
        /// </summary>
		[RelationshipSchemaName("plugintype_customapi")]
		public IEnumerable<CustomAPI> PlugintypeCustomapi
		{
			get { return GetRelatedEntities<CustomAPI>("plugintype_customapi", null); }
			set { SetRelatedEntities("plugintype_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'plugintype_plugintypestatistic'
        /// </summary>
		[RelationshipSchemaName("plugintype_plugintypestatistic")]
		public IEnumerable<PluginTypeStatistic> PlugintypePlugintypestatistic
		{
			get { return GetRelatedEntities<PluginTypeStatistic>("plugintype_plugintypestatistic", null); }
			set { SetRelatedEntities("plugintype_plugintypestatistic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'plugintype_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> PlugintypeSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("plugintype_sdkmessageprocessingstep", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'plugintypeid_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> PlugintypeidSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("plugintypeid_sdkmessageprocessingstep", null, value); }
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
			/// <summary>assemblyname</summary>
			public const string AssemblyName = "assemblyname";

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

			/// <summary>culture</summary>
			public const string Culture = "culture";

			/// <summary>customizationlevel</summary>
			public const string Customizationlevel = "customizationlevel";

			/// <summary>customworkflowactivityinfo</summary>
			public const string CustomWorkflowActivityInfo = "customworkflowactivityinfo";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>friendlyname</summary>
			public const string DisplayName = "friendlyname";

			/// <summary>ismanaged</summary>
			public const string Ismanaged = "ismanaged";

			/// <summary>isworkflowactivity</summary>
			public const string IsWorkflowActivity = "isworkflowactivity";

			/// <summary>major</summary>
			public const string VersionMajor = "major";

			/// <summary>minor</summary>
			public const string VersionMinor = "minor";

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

			/// <summary>pluginassemblyid</summary>
			public const string PluginAssembly = "pluginassemblyid";

			/// <summary>pluginassemblyidname</summary>
			public const string Pluginassemblyidname = "pluginassemblyidname";

			/// <summary>plugintypeid</summary>
			public const string PluginTypeId = "plugintypeid";

			/// <summary>plugintypeidunique</summary>
			public const string PlugintypeiduniqueId = "plugintypeidunique";

			/// <summary>publickeytoken</summary>
			public const string PublicKeyToken = "publickeytoken";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>typename</summary>
			public const string TypeName = "typename";

			/// <summary>version</summary>
			public const string Version = "version";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>workflowactivitygroupname</summary>
			public const string WorkflowActivityGroupName = "workflowactivitygroupname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N plugin_type_service</summary>
			public const string PluginTypeService = "plugin_type_service";

			/// <summary>1:N plugintype_customapi</summary>
			public const string PlugintypeCustomapi = "plugintype_customapi";

			/// <summary>1:N plugintype_plugintypestatistic</summary>
			public const string PlugintypePlugintypestatistic = "plugintype_plugintypestatistic";

			/// <summary>1:N plugintype_sdkmessageprocessingstep</summary>
			public const string PlugintypeSdkmessageprocessingstep = "plugintype_sdkmessageprocessingstep";

			/// <summary>1:N plugintypeid_sdkmessageprocessingstep</summary>
			public const string PlugintypeidSdkmessageprocessingstep = "plugintypeid_sdkmessageprocessingstep";

		}
		#endregion
	}
}

