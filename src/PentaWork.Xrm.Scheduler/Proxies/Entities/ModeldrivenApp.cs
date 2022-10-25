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
	[EntityLogicalName("appmodule")]
	public sealed class ModeldrivenApp : Entity
	{	
		public static readonly int? EntityTypeCode = 9006;
		public new const string LogicalName = "appmodule";
		public const string PrimaryIdAttribute = "appmoduleid";
		public const string PrimaryNameAttribute = "name";
	
		public ModeldrivenApp() : base("appmodule") { }

		#region Attributes
		/// <summary>
        /// appmoduleid
        /// </summary>
		[DisplayName("AppModuleId")]
		[AttributeLogicalName("appmoduleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("appmoduleid", value); }
		}

							/// <summary>
        /// appmoduleidunique
        /// </summary>
		[DisplayName("App Module Unique Id")]
		[AttributeLogicalName("appmoduleidunique")]
		public Guid AppModuleUniqueId
		{	
			get { return GetAttributeValue<Guid>("appmoduleidunique"); }
			set
			{ 
				if(value == AppModuleUniqueId) return;
				SetAttributeValue("appmoduleidunique", value);
			}
		}	
			
		/// <summary>
        /// appmoduleversion
        /// </summary>
		[DisplayName("App Module Version")]
		[AttributeLogicalName("appmoduleversion")]
		public string AppModuleVersion
		{	
			get { return GetAttributeValue<string>("appmoduleversion"); }
			set
			{ 
				if(value == AppModuleVersion) return;
				SetAttributeValue("appmoduleversion", value);
			}
		}	
			
		/// <summary>
        /// appmodulexmlmanaged
        /// </summary>
		[DisplayName("appmodulexmlmanaged")]
		[AttributeLogicalName("appmodulexmlmanaged")]
		public string Appmodulexmlmanaged
		{	
			get { return GetAttributeValue<string>("appmodulexmlmanaged"); }
			set
			{ 
				if(value == Appmodulexmlmanaged) return;
				SetAttributeValue("appmodulexmlmanaged", value);
			}
		}	
			
		/// <summary>
        /// clienttype
        /// </summary>
		[DisplayName("Client Type")]
		[AttributeLogicalName("clienttype")]
		public int? ClientType
		{	
			get { return GetAttributeValue<int?>("clienttype"); }
			set
			{ 
				if(value == ClientType) return;
				SetAttributeValue("clienttype", value);
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
        /// configxml
        /// </summary>
		[DisplayName("configxml")]
		[AttributeLogicalName("configxml")]
		public string Configxml
		{	
			get { return GetAttributeValue<string>("configxml"); }
			set
			{ 
				if(value == Configxml) return;
				SetAttributeValue("configxml", value);
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
        /// descriptor
        /// </summary>
		[DisplayName("Descriptor")]
		[AttributeLogicalName("descriptor")]
		public string Descriptor
		{	
			get { return GetAttributeValue<string>("descriptor"); }
			set
			{ 
				if(value == Descriptor) return;
				SetAttributeValue("descriptor", value);
			}
		}	
			
		/// <summary>
        /// eventhandlers
        /// </summary>
		[DisplayName("Event Handlers")]
		[AttributeLogicalName("eventhandlers")]
		public string EventHandlers
		{	
			get { return GetAttributeValue<string>("eventhandlers"); }
			set
			{ 
				if(value == EventHandlers) return;
				SetAttributeValue("eventhandlers", value);
			}
		}	
			
		/// <summary>
        /// formfactor
        /// </summary>
		[DisplayName("Form Factor")]
		[AttributeLogicalName("formfactor")]
		public int? FormFactor
		{	
			get { return GetAttributeValue<int?>("formfactor"); }
			set
			{ 
				if(value == FormFactor) return;
				SetAttributeValue("formfactor", value);
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
        /// isdefault
        /// </summary>
		[DisplayName("Is Default")]
		[AttributeLogicalName("isdefault")]
		public bool? IsDefault
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == IsDefault) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// isfeatured
        /// </summary>
		[DisplayName("IsFeatured")]
		[AttributeLogicalName("isfeatured")]
		public bool? IsFeatured
		{	
			get { return GetAttributeValue<bool?>("isfeatured"); }
			set
			{ 
				if(value == IsFeatured) return;
				SetAttributeValue("isfeatured", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("IsManaged")]
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
        /// navigationtype
        /// </summary>
		[DisplayName("Navigation type")]
		[AttributeLogicalName("navigationtype")]
		public eNavigationType? NavigationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("navigationtype");
				if (optionSetValue != null) return (eNavigationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == NavigationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("navigationtype", optionSetValue); 
			}
		}

		/// <summary>
        /// optimizedfor
        /// </summary>
		[DisplayName("Optimized Client")]
		[AttributeLogicalName("optimizedfor")]
		public string OptimizedClient
		{	
			get { return GetAttributeValue<string>("optimizedfor"); }
			set
			{ 
				if(value == OptimizedClient) return;
				SetAttributeValue("optimizedfor", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
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
		[DisplayName("Overwrite Time")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? OverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == OverwriteTime) return;
				SetAttributeValue("overwritetime", value);
			}
		}	
			
		/// <summary>
        /// publishedon
        /// </summary>
		[DisplayName("Published On")]
		[AttributeLogicalName("publishedon")]
		public DateTime? PublishedOn
		{	
			get { return GetAttributeValue<DateTime?>("publishedon"); }
			set
			{ 
				if(value == PublishedOn) return;
				SetAttributeValue("publishedon", value);
			}
		}	
			
		/// <summary>
        /// publisherid
        /// </summary>
		[DisplayName("Publisher")]
		[AttributeLogicalName("publisherid")]
		public EntityReference Publisher
		{	
			get { return GetAttributeValue<EntityReference>("publisherid"); }
			set
			{ 
				if(value == Publisher) return;
				SetAttributeValue("publisherid", value);
			}
		}	
			
		/// <summary>
        /// publisheridname
        /// </summary>
		[DisplayName("Publisher")]
		[AttributeLogicalName("publisheridname")]
		public string Publisher2
		{	
			get { return GetAttributeValue<string>("publisheridname"); }
			set
			{ 
				if(value == Publisher2) return;
				SetAttributeValue("publisheridname", value);
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
        /// url
        /// </summary>
		[DisplayName("URL")]
		[AttributeLogicalName("url")]
		public string URL
		{	
			get { return GetAttributeValue<string>("url"); }
			set
			{ 
				if(value == URL) return;
				SetAttributeValue("url", value);
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
        /// webresourceid
        /// </summary>
		[DisplayName("Web Resource Id")]
		[AttributeLogicalName("webresourceid")]
		public Guid WebResourceId
		{	
			get { return GetAttributeValue<Guid>("webresourceid"); }
			set
			{ 
				if(value == WebResourceId) return;
				SetAttributeValue("webresourceid", value);
			}
		}	
			
		/// <summary>
        /// welcomepageid
        /// </summary>
		[DisplayName("Welcome Page Id")]
		[AttributeLogicalName("welcomepageid")]
		public Guid WelcomePageId
		{	
			get { return GetAttributeValue<Guid>("welcomepageid"); }
			set
			{ 
				if(value == WelcomePageId) return;
				SetAttributeValue("welcomepageid", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'appmodule_appconfig'
        /// </summary>
		[RelationshipSchemaName("appmodule_appconfig")]
		public IEnumerable<AppConfiguration> AppmoduleAppconfig
		{
			get { return GetRelatedEntities<AppConfiguration>("appmodule_appconfig", null); }
			set { SetRelatedEntities("appmodule_appconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appmodule_appmodulecomponent'
        /// </summary>
		[RelationshipSchemaName("appmodule_appmodulecomponent")]
		public IEnumerable<AppModuleComponent> AppmoduleAppmodulecomponent
		{
			get { return GetRelatedEntities<AppModuleComponent>("appmodule_appmodulecomponent", null); }
			set { SetRelatedEntities("appmodule_appmodulecomponent", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SecurityRole'
        /// </summary>
		[RelationshipSchemaName("appmoduleroles_association")]
		public IEnumerable<SecurityRole> AppmodulerolesAssociation
		{
			get { return GetRelatedEntities<SecurityRole>("appmoduleroles_association", null); }
			set { SetRelatedEntities("appmoduleroles_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'ServicePlan'
        /// </summary>
		[RelationshipSchemaName("serviceplan_appmodule")]
		public IEnumerable<ServicePlan> ServiceplanAppmodule
		{
			get { return GetRelatedEntities<ServicePlan>("serviceplan_appmodule", null); }
			set { SetRelatedEntities("serviceplan_appmodule", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eNavigationType
		{	
		
			[Label("Single session")]
			[Description(@"")]
			SingleSession = 0, 
		
			[Label("Multi session")]
			[Description(@"")]
			MultiSession = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted_Inactive = 3, 
		}
		
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
			/// <summary>appmoduleid</summary>
			public const string AppModuleId = "appmoduleid";

			/// <summary>appmoduleidunique</summary>
			public const string AppModuleUniqueId = "appmoduleidunique";

			/// <summary>appmoduleversion</summary>
			public const string AppModuleVersion = "appmoduleversion";

			/// <summary>appmodulexmlmanaged</summary>
			public const string Appmodulexmlmanaged = "appmodulexmlmanaged";

			/// <summary>clienttype</summary>
			public const string ClientType = "clienttype";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>configxml</summary>
			public const string Configxml = "configxml";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>descriptor</summary>
			public const string Descriptor = "descriptor";

			/// <summary>eventhandlers</summary>
			public const string EventHandlers = "eventhandlers";

			/// <summary>formfactor</summary>
			public const string FormFactor = "formfactor";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isdefault</summary>
			public const string IsDefault = "isdefault";

			/// <summary>isfeatured</summary>
			public const string IsFeatured = "isfeatured";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

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

			/// <summary>navigationtype</summary>
			public const string NavigationType = "navigationtype";

			/// <summary>optimizedfor</summary>
			public const string OptimizedClient = "optimizedfor";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string OverwriteTime = "overwritetime";

			/// <summary>publishedon</summary>
			public const string PublishedOn = "publishedon";

			/// <summary>publisherid</summary>
			public const string Publisher = "publisherid";

			/// <summary>publisheridname</summary>
			public const string Publisher2 = "publisheridname";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>uniquename</summary>
			public const string UniqueName = "uniquename";

			/// <summary>url</summary>
			public const string URL = "url";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>webresourceid</summary>
			public const string WebResourceId = "webresourceid";

			/// <summary>welcomepageid</summary>
			public const string WelcomePageId = "welcomepageid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N appmodule_appconfig</summary>
			public const string AppmoduleAppconfig = "appmodule_appconfig";

			/// <summary>1:N appmodule_appmodulecomponent</summary>
			public const string AppmoduleAppmodulecomponent = "appmodule_appmodulecomponent";

			/// <summary>N:N appmoduleroles_association</summary>
			public const string AppmodulerolesAssociation = "appmoduleroles_association";

			/// <summary>N:N serviceplan_appmodule</summary>
			public const string ServiceplanAppmodule = "serviceplan_appmodule";

		}
		#endregion
	}
}

