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
	[EntityLogicalName("pluginassembly")]
	public sealed class PluginAssembly : Entity
	{	
		public static readonly int? EntityTypeCode = 4605;
		public new const string LogicalName = "pluginassembly";
		public const string PrimaryIdAttribute = "pluginassemblyid";
		public const string PrimaryNameAttribute = "name";
	
		public PluginAssembly() : base("pluginassembly") { }

		#region Attributes
		/// <summary>
        /// authtype
        /// </summary>
		[DisplayName("Specifies mode of authentication with web sources")]
		[AttributeLogicalName("authtype")]
		public eAuthType? SpecifiesModeOfAuthenticationWithWebSources
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("authtype");
				if (optionSetValue != null) return (eAuthType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SpecifiesModeOfAuthenticationWithWebSources) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("authtype", optionSetValue); 
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
        /// content
        /// </summary>
		[DisplayName("content")]
		[AttributeLogicalName("content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("content", value);
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
        /// isolationmode
        /// </summary>
		[DisplayName("Isolation Mode")]
		[AttributeLogicalName("isolationmode")]
		public eIsolationMode? IsolationMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("isolationmode");
				if (optionSetValue != null) return (eIsolationMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IsolationMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("isolationmode", optionSetValue); 
			}
		}

		/// <summary>
        /// ispasswordset
        /// </summary>
		[DisplayName("ispasswordset")]
		[AttributeLogicalName("ispasswordset")]
		public bool? Ispasswordset
		{	
			get { return GetAttributeValue<bool?>("ispasswordset"); }
			set
			{ 
				if(value == Ispasswordset) return;
				SetAttributeValue("ispasswordset", value);
			}
		}	
			
		/// <summary>
        /// major
        /// </summary>
		[DisplayName("major")]
		[AttributeLogicalName("major")]
		public int? Major
		{	
			get { return GetAttributeValue<int?>("major"); }
			set
			{ 
				if(value == Major) return;
				SetAttributeValue("major", value);
			}
		}	
			
		/// <summary>
        /// minor
        /// </summary>
		[DisplayName("minor")]
		[AttributeLogicalName("minor")]
		public int? Minor
		{	
			get { return GetAttributeValue<int?>("minor"); }
			set
			{ 
				if(value == Minor) return;
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
        /// password
        /// </summary>
		[DisplayName("User Password")]
		[AttributeLogicalName("password")]
		public string UserPassword
		{	
			get { return GetAttributeValue<string>("password"); }
			set
			{ 
				if(value == UserPassword) return;
				SetAttributeValue("password", value);
			}
		}	
			
		/// <summary>
        /// path
        /// </summary>
		[DisplayName("Path")]
		[AttributeLogicalName("path")]
		public string Path
		{	
			get { return GetAttributeValue<string>("path"); }
			set
			{ 
				if(value == Path) return;
				SetAttributeValue("path", value);
			}
		}	
			
		/// <summary>
        /// pluginassemblyid
        /// </summary>
		[DisplayName("pluginassemblyid")]
		[AttributeLogicalName("pluginassemblyid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("pluginassemblyid", value); }
		}

							/// <summary>
        /// pluginassemblyidunique
        /// </summary>
		[DisplayName("pluginassemblyidunique")]
		[AttributeLogicalName("pluginassemblyidunique")]
		public Guid PluginassemblyiduniqueId
		{	
			get { return GetAttributeValue<Guid>("pluginassemblyidunique"); }
			set
			{ 
				if(value == PluginassemblyiduniqueId) return;
				SetAttributeValue("pluginassemblyidunique", value);
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
        /// sourcehash
        /// </summary>
		[DisplayName("sourcehash")]
		[AttributeLogicalName("sourcehash")]
		public string Sourcehash
		{	
			get { return GetAttributeValue<string>("sourcehash"); }
			set
			{ 
				if(value == Sourcehash) return;
				SetAttributeValue("sourcehash", value);
			}
		}	
			
		/// <summary>
        /// sourcetype
        /// </summary>
		[DisplayName("Source Type")]
		[AttributeLogicalName("sourcetype")]
		public eSourceType? SourceType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("sourcetype");
				if (optionSetValue != null) return (eSourceType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SourceType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("sourcetype", optionSetValue); 
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
        /// url
        /// </summary>
		[DisplayName("Web Url")]
		[AttributeLogicalName("url")]
		public string WebUrl
		{	
			get { return GetAttributeValue<string>("url"); }
			set
			{ 
				if(value == WebUrl) return;
				SetAttributeValue("url", value);
			}
		}	
			
		/// <summary>
        /// username
        /// </summary>
		[DisplayName("User Name")]
		[AttributeLogicalName("username")]
		public string UserName
		{	
			get { return GetAttributeValue<string>("username"); }
			set
			{ 
				if(value == UserName) return;
				SetAttributeValue("username", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'pluginassembly_plugintype'
        /// </summary>
		[RelationshipSchemaName("pluginassembly_plugintype")]
		public IEnumerable<PluginType> PluginassemblyPlugintype
		{
			get { return GetRelatedEntities<PluginType>("pluginassembly_plugintype", null); }
			set { SetRelatedEntities("pluginassembly_plugintype", null, value); }
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
		
		public enum eAuthType
		{	
		
			[Label("BasicAuth")]
			[Description(@"")]
			BasicAuth = 0, 
		}
		
		public enum eIsolationMode
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 1, 
		
			[Label("Sandbox")]
			[Description(@"")]
			Sandbox = 2, 
		
			[Label("External")]
			[Description(@"")]
			External = 3, 
		}
		
		public enum eSourceType
		{	
		
			[Label("Database")]
			[Description(@"")]
			Database = 0, 
		
			[Label("Disk")]
			[Description(@"")]
			Disk = 1, 
		
			[Label("Normal")]
			[Description(@"")]
			Normal = 2, 
		
			[Label("AzureWebApp")]
			[Description(@"")]
			AzureWebApp = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>authtype</summary>
			public const string SpecifiesModeOfAuthenticationWithWebSources = "authtype";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>content</summary>
			public const string Content = "content";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>isolationmode</summary>
			public const string IsolationMode = "isolationmode";

			/// <summary>ispasswordset</summary>
			public const string Ispasswordset = "ispasswordset";

			/// <summary>major</summary>
			public const string Major = "major";

			/// <summary>minor</summary>
			public const string Minor = "minor";

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

			/// <summary>password</summary>
			public const string UserPassword = "password";

			/// <summary>path</summary>
			public const string Path = "path";

			/// <summary>pluginassemblyid</summary>
			public const string PluginassemblyId = "pluginassemblyid";

			/// <summary>pluginassemblyidunique</summary>
			public const string PluginassemblyiduniqueId = "pluginassemblyidunique";

			/// <summary>publickeytoken</summary>
			public const string PublicKeyToken = "publickeytoken";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>sourcehash</summary>
			public const string Sourcehash = "sourcehash";

			/// <summary>sourcetype</summary>
			public const string SourceType = "sourcetype";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>url</summary>
			public const string WebUrl = "url";

			/// <summary>username</summary>
			public const string UserName = "username";

			/// <summary>version</summary>
			public const string Version = "version";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N pluginassembly_plugintype</summary>
			public const string PluginassemblyPlugintype = "pluginassembly_plugintype";

		}
		#endregion
	}
}

