using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{DisplayName}")] 	
	[EntityLogicalName("solution")]
	public sealed class Solution : Entity
	{	
		public static readonly int? EntityTypeCode = 7100;
		public new const string LogicalName = "solution";
		public const string PrimaryIdAttribute = "solutionid";
		public const string PrimaryNameAttribute = "friendlyname";
	
		public Solution() : base("solution") { }

		#region Attributes
		/// <summary>
        /// configurationpageid
        /// </summary>
		[DisplayName("Configuration Page")]
		[AttributeLogicalName("configurationpageid")]
		public EntityReference ConfigurationPage
		{	
			get { return GetAttributeValue<EntityReference>("configurationpageid"); }
			set
			{ 
				if(value == ConfigurationPage) return;
				SetAttributeValue("configurationpageid", value);
			}
		}	
			
		/// <summary>
        /// configurationpageidname
        /// </summary>
		[DisplayName("configurationpageidname")]
		[AttributeLogicalName("configurationpageidname")]
		public string Configurationpageidname
		{	
			get { return GetAttributeValue<string>("configurationpageidname"); }
			set
			{ 
				if(value == Configurationpageidname) return;
				SetAttributeValue("configurationpageidname", value);
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
        /// installedon
        /// </summary>
		[DisplayName("Installed On")]
		[AttributeLogicalName("installedon")]
		public DateTime? InstalledOn
		{	
			get { return GetAttributeValue<DateTime?>("installedon"); }
			set
			{ 
				if(value == InstalledOn) return;
				SetAttributeValue("installedon", value);
			}
		}	
			
		/// <summary>
        /// isapimanaged
        /// </summary>
		[DisplayName("Is Api Managed Solution")]
		[AttributeLogicalName("isapimanaged")]
		public bool? IsApiManagedSolution
		{	
			get { return GetAttributeValue<bool?>("isapimanaged"); }
			set
			{ 
				if(value == IsApiManagedSolution) return;
				SetAttributeValue("isapimanaged", value);
			}
		}	
			
		/// <summary>
        /// isinternal
        /// </summary>
		[DisplayName("Is internal solution")]
		[AttributeLogicalName("isinternal")]
		public bool? IsInternalSolution
		{	
			get { return GetAttributeValue<bool?>("isinternal"); }
			set
			{ 
				if(value == IsInternalSolution) return;
				SetAttributeValue("isinternal", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("Package Type")]
		[AttributeLogicalName("ismanaged")]
		public bool? PackageType
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == PackageType) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// isvisible
        /// </summary>
		[DisplayName("Is Visible Outside Platform")]
		[AttributeLogicalName("isvisible")]
		public bool? IsVisibleOutsidePlatform
		{	
			get { return GetAttributeValue<bool?>("isvisible"); }
			set
			{ 
				if(value == IsVisibleOutsidePlatform) return;
				SetAttributeValue("isvisible", value);
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
        /// parentsolutionid
        /// </summary>
		[DisplayName("Parent Solution")]
		[AttributeLogicalName("parentsolutionid")]
		public EntityReference ParentSolution
		{	
			get { return GetAttributeValue<EntityReference>("parentsolutionid"); }
			set
			{ 
				if(value == ParentSolution) return;
				SetAttributeValue("parentsolutionid", value);
			}
		}	
			
		/// <summary>
        /// parentsolutionidname
        /// </summary>
		[DisplayName("parentsolutionidname")]
		[AttributeLogicalName("parentsolutionidname")]
		public string Parentsolutionidname
		{	
			get { return GetAttributeValue<string>("parentsolutionidname"); }
			set
			{ 
				if(value == Parentsolutionidname) return;
				SetAttributeValue("parentsolutionidname", value);
			}
		}	
			
		/// <summary>
        /// pinpointassetid
        /// </summary>
		[DisplayName("pinpointassetid")]
		[AttributeLogicalName("pinpointassetid")]
		public string Pinpointassetid
		{	
			get { return GetAttributeValue<string>("pinpointassetid"); }
			set
			{ 
				if(value == Pinpointassetid) return;
				SetAttributeValue("pinpointassetid", value);
			}
		}	
			
		/// <summary>
        /// pinpointpublisherid
        /// </summary>
		[DisplayName("pinpointpublisherid")]
		[AttributeLogicalName("pinpointpublisherid")]
		public int? Pinpointpublisherid
		{	
			get { return GetAttributeValue<int?>("pinpointpublisherid"); }
			set
			{ 
				if(value == Pinpointpublisherid) return;
				SetAttributeValue("pinpointpublisherid", value);
			}
		}	
			
		/// <summary>
        /// pinpointsolutiondefaultlocale
        /// </summary>
		[DisplayName("pinpointsolutiondefaultlocale")]
		[AttributeLogicalName("pinpointsolutiondefaultlocale")]
		public string Pinpointsolutiondefaultlocale
		{	
			get { return GetAttributeValue<string>("pinpointsolutiondefaultlocale"); }
			set
			{ 
				if(value == Pinpointsolutiondefaultlocale) return;
				SetAttributeValue("pinpointsolutiondefaultlocale", value);
			}
		}	
			
		/// <summary>
        /// pinpointsolutionid
        /// </summary>
		[DisplayName("pinpointsolutionid")]
		[AttributeLogicalName("pinpointsolutionid")]
		public int? Pinpointsolutionid
		{	
			get { return GetAttributeValue<int?>("pinpointsolutionid"); }
			set
			{ 
				if(value == Pinpointsolutionid) return;
				SetAttributeValue("pinpointsolutionid", value);
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
        /// publisheridoptionvalueprefix
        /// </summary>
		[DisplayName("publisheridoptionvalueprefix")]
		[AttributeLogicalName("publisheridoptionvalueprefix")]
		public int? Publisheridoptionvalueprefix
		{	
			get { return GetAttributeValue<int?>("publisheridoptionvalueprefix"); }
			set
			{ 
				if(value == Publisheridoptionvalueprefix) return;
				SetAttributeValue("publisheridoptionvalueprefix", value);
			}
		}	
			
		/// <summary>
        /// publisheridprefix
        /// </summary>
		[DisplayName("publisheridprefix")]
		[AttributeLogicalName("publisheridprefix")]
		public string Publisheridprefix
		{	
			get { return GetAttributeValue<string>("publisheridprefix"); }
			set
			{ 
				if(value == Publisheridprefix) return;
				SetAttributeValue("publisheridprefix", value);
			}
		}	
			
		/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution Identifier")]
		[AttributeLogicalName("solutionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("solutionid", value); }
		}

							/// <summary>
        /// solutionpackageversion
        /// </summary>
		[DisplayName("Solution Package Version")]
		[AttributeLogicalName("solutionpackageversion")]
		public string SolutionPackageVersion
		{	
			get { return GetAttributeValue<string>("solutionpackageversion"); }
			set
			{ 
				if(value == SolutionPackageVersion) return;
				SetAttributeValue("solutionpackageversion", value);
			}
		}	
			
		/// <summary>
        /// solutiontype
        /// </summary>
		[DisplayName("Solution Type")]
		[AttributeLogicalName("solutiontype")]
		public eSolutionType? SolutionType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("solutiontype");
				if (optionSetValue != null) return (eSolutionType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SolutionType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("solutiontype", optionSetValue); 
			}
		}

		/// <summary>
        /// uniquename
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("uniquename")]
		public string Name
		{	
			get { return GetAttributeValue<string>("uniquename"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("uniquename", value);
			}
		}	
			
		/// <summary>
        /// updatedon
        /// </summary>
		[DisplayName("Updated On")]
		[AttributeLogicalName("updatedon")]
		public DateTime? UpdatedOn
		{	
			get { return GetAttributeValue<DateTime?>("updatedon"); }
			set
			{ 
				if(value == UpdatedOn) return;
				SetAttributeValue("updatedon", value);
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
        /// 1:N Get entities for 'FileAttachment_Solution'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_Solution")]
		public IEnumerable<FileAttachment> FileAttachmentSolution
		{
			get { return GetRelatedEntities<FileAttachment>("FileAttachment_Solution", null); }
			set { SetRelatedEntities("FileAttachment_Solution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FK_CanvasApp_Solution'
        /// </summary>
		[RelationshipSchemaName("FK_CanvasApp_Solution")]
		public IEnumerable<CanvasApp> FKCanvasAppSolution
		{
			get { return GetRelatedEntities<CanvasApp>("FK_CanvasApp_Solution", null); }
			set { SetRelatedEntities("FK_CanvasApp_Solution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_fieldpermission'
        /// </summary>
		[RelationshipSchemaName("solution_fieldpermission")]
		public IEnumerable<FieldPermission> SolutionFieldpermission
		{
			get { return GetRelatedEntities<FieldPermission>("solution_fieldpermission", null); }
			set { SetRelatedEntities("solution_fieldpermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_fieldsecurityprofile'
        /// </summary>
		[RelationshipSchemaName("solution_fieldsecurityprofile")]
		public IEnumerable<FieldSecurityProfile> SolutionFieldsecurityprofile
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("solution_fieldsecurityprofile", null); }
			set { SetRelatedEntities("solution_fieldsecurityprofile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_parent_solution'
        /// </summary>
		[RelationshipSchemaName("solution_parent_solution")]
		public IEnumerable<Solution> SolutionParentSolution
		{
			get { return GetRelatedEntities<Solution>("solution_parent_solution", null); }
			set { SetRelatedEntities("solution_parent_solution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_privilege'
        /// </summary>
		[RelationshipSchemaName("solution_privilege")]
		public IEnumerable<Privilege> SolutionPrivilege
		{
			get { return GetRelatedEntities<Privilege>("solution_privilege", null); }
			set { SetRelatedEntities("solution_privilege", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_role'
        /// </summary>
		[RelationshipSchemaName("solution_role")]
		public IEnumerable<SecurityRole> SolutionRole
		{
			get { return GetRelatedEntities<SecurityRole>("solution_role", null); }
			set { SetRelatedEntities("solution_role", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_solutioncomponent'
        /// </summary>
		[RelationshipSchemaName("solution_solutioncomponent")]
		public IEnumerable<SolutionComponent> SolutionSolutioncomponent
		{
			get { return GetRelatedEntities<SolutionComponent>("solution_solutioncomponent", null); }
			set { SetRelatedEntities("solution_solutioncomponent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Solution_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Solution_SyncErrors")]
		public IEnumerable<SyncError> SolutionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Solution_SyncErrors", null); }
			set { SetRelatedEntities("Solution_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Package'
        /// </summary>
		[RelationshipSchemaName("package_solution")]
		public IEnumerable<Package> PackageSolution
		{
			get { return GetRelatedEntities<Package>("package_solution", null); }
			set { SetRelatedEntities("package_solution", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eSolutionType
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Snapshot")]
			[Description(@"")]
			Snapshot = 1, 
		
			[Label("Internal")]
			[Description(@"")]
			Internal = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>configurationpageid</summary>
			public const string ConfigurationPage = "configurationpageid";

			/// <summary>configurationpageidname</summary>
			public const string Configurationpageidname = "configurationpageidname";

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

			/// <summary>friendlyname</summary>
			public const string DisplayName = "friendlyname";

			/// <summary>installedon</summary>
			public const string InstalledOn = "installedon";

			/// <summary>isapimanaged</summary>
			public const string IsApiManagedSolution = "isapimanaged";

			/// <summary>isinternal</summary>
			public const string IsInternalSolution = "isinternal";

			/// <summary>ismanaged</summary>
			public const string PackageType = "ismanaged";

			/// <summary>isvisible</summary>
			public const string IsVisibleOutsidePlatform = "isvisible";

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

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>parentsolutionid</summary>
			public const string ParentSolution = "parentsolutionid";

			/// <summary>parentsolutionidname</summary>
			public const string Parentsolutionidname = "parentsolutionidname";

			/// <summary>pinpointassetid</summary>
			public const string Pinpointassetid = "pinpointassetid";

			/// <summary>pinpointpublisherid</summary>
			public const string Pinpointpublisherid = "pinpointpublisherid";

			/// <summary>pinpointsolutiondefaultlocale</summary>
			public const string Pinpointsolutiondefaultlocale = "pinpointsolutiondefaultlocale";

			/// <summary>pinpointsolutionid</summary>
			public const string Pinpointsolutionid = "pinpointsolutionid";

			/// <summary>publisherid</summary>
			public const string Publisher = "publisherid";

			/// <summary>publisheridname</summary>
			public const string Publisher2 = "publisheridname";

			/// <summary>publisheridoptionvalueprefix</summary>
			public const string Publisheridoptionvalueprefix = "publisheridoptionvalueprefix";

			/// <summary>publisheridprefix</summary>
			public const string Publisheridprefix = "publisheridprefix";

			/// <summary>solutionid</summary>
			public const string SolutionIdentifierId = "solutionid";

			/// <summary>solutionpackageversion</summary>
			public const string SolutionPackageVersion = "solutionpackageversion";

			/// <summary>solutiontype</summary>
			public const string SolutionType = "solutiontype";

			/// <summary>uniquename</summary>
			public const string Name = "uniquename";

			/// <summary>updatedon</summary>
			public const string UpdatedOn = "updatedon";

			/// <summary>version</summary>
			public const string Version = "version";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N FileAttachment_Solution</summary>
			public const string FileAttachmentSolution = "FileAttachment_Solution";

			/// <summary>1:N FK_CanvasApp_Solution</summary>
			public const string FKCanvasAppSolution = "FK_CanvasApp_Solution";

			/// <summary>1:N solution_fieldpermission</summary>
			public const string SolutionFieldpermission = "solution_fieldpermission";

			/// <summary>1:N solution_fieldsecurityprofile</summary>
			public const string SolutionFieldsecurityprofile = "solution_fieldsecurityprofile";

			/// <summary>1:N solution_parent_solution</summary>
			public const string SolutionParentSolution = "solution_parent_solution";

			/// <summary>1:N solution_privilege</summary>
			public const string SolutionPrivilege = "solution_privilege";

			/// <summary>1:N solution_role</summary>
			public const string SolutionRole = "solution_role";

			/// <summary>1:N solution_solutioncomponent</summary>
			public const string SolutionSolutioncomponent = "solution_solutioncomponent";

			/// <summary>1:N Solution_SyncErrors</summary>
			public const string SolutionSyncErrors = "Solution_SyncErrors";

			/// <summary>N:N package_solution</summary>
			public const string PackageSolution = "package_solution";

		}
		#endregion
	}
}

