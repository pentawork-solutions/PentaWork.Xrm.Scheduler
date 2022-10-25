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
	[EntityLogicalName("role")]
	public sealed class SecurityRole : Entity
	{	
		public static readonly int? EntityTypeCode = 1036;
		public new const string LogicalName = "role";
		public const string PrimaryIdAttribute = "roleid";
		public const string PrimaryNameAttribute = "name";
	
		public SecurityRole() : base("role") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
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
		[DisplayName("Created By Impersonator")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference CreatedByImpersonator
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == CreatedByImpersonator) return;
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
        /// isinherited
        /// </summary>
		[DisplayName("Is Inherited")]
		[AttributeLogicalName("isinherited")]
		public egIsInherited? IsInherited
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("isinherited");
				if (optionSetValue != null) return (egIsInherited)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IsInherited) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("isinherited", optionSetValue); 
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
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// parentroleid
        /// </summary>
		[DisplayName("Parent Role")]
		[AttributeLogicalName("parentroleid")]
		public EntityReference ParentRole
		{	
			get { return GetAttributeValue<EntityReference>("parentroleid"); }
			set
			{ 
				if(value == ParentRole) return;
				SetAttributeValue("parentroleid", value);
			}
		}	
			
		/// <summary>
        /// parentroleidname
        /// </summary>
		[DisplayName("parentroleidname")]
		[AttributeLogicalName("parentroleidname")]
		public string Parentroleidname
		{	
			get { return GetAttributeValue<string>("parentroleidname"); }
			set
			{ 
				if(value == Parentroleidname) return;
				SetAttributeValue("parentroleidname", value);
			}
		}	
			
		/// <summary>
        /// parentrootroleid
        /// </summary>
		[DisplayName("Parent Root Role")]
		[AttributeLogicalName("parentrootroleid")]
		public EntityReference ParentRootRole
		{	
			get { return GetAttributeValue<EntityReference>("parentrootroleid"); }
			set
			{ 
				if(value == ParentRootRole) return;
				SetAttributeValue("parentrootroleid", value);
			}
		}	
			
		/// <summary>
        /// parentrootroleidname
        /// </summary>
		[DisplayName("parentrootroleidname")]
		[AttributeLogicalName("parentrootroleidname")]
		public string Parentrootroleidname
		{	
			get { return GetAttributeValue<string>("parentrootroleidname"); }
			set
			{ 
				if(value == Parentrootroleidname) return;
				SetAttributeValue("parentrootroleidname", value);
			}
		}	
			
		/// <summary>
        /// roleid
        /// </summary>
		[DisplayName("Role")]
		[AttributeLogicalName("roleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("roleid", value); }
		}

							/// <summary>
        /// roleidunique
        /// </summary>
		[DisplayName("Unique Id")]
		[AttributeLogicalName("roleidunique")]
		public Guid UniqueId
		{	
			get { return GetAttributeValue<Guid>("roleidunique"); }
			set
			{ 
				if(value == UniqueId) return;
				SetAttributeValue("roleidunique", value);
			}
		}	
			
		/// <summary>
        /// roletemplateid
        /// </summary>
		[DisplayName("Role Template")]
		[AttributeLogicalName("roletemplateid")]
		public EntityReference RoleTemplate
		{	
			get { return GetAttributeValue<EntityReference>("roletemplateid"); }
			set
			{ 
				if(value == RoleTemplate) return;
				SetAttributeValue("roletemplateid", value);
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
        /// versionnumber
        /// </summary>
		[DisplayName("Version number")]
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
        /// 1:N Get entities for 'lk_msdyn_roleid'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_roleid")]
		public IEnumerable<ActionCardRoleSetting> LkMsdynRoleid
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("lk_msdyn_roleid", null); }
			set { SetRelatedEntities("lk_msdyn_roleid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Role_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Role_AsyncOperations")]
		public IEnumerable<SystemJob> RoleAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Role_AsyncOperations", null); }
			set { SetRelatedEntities("Role_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Role_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Role_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> RoleBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Role_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Role_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'role_parent_role'
        /// </summary>
		[RelationshipSchemaName("role_parent_role")]
		public IEnumerable<SecurityRole> RoleParentRole
		{
			get { return GetRelatedEntities<SecurityRole>("role_parent_role", null); }
			set { SetRelatedEntities("role_parent_role", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'role_parent_root_role'
        /// </summary>
		[RelationshipSchemaName("role_parent_root_role")]
		public IEnumerable<SecurityRole> RoleParentRootRole
		{
			get { return GetRelatedEntities<SecurityRole>("role_parent_root_role", null); }
			set { SetRelatedEntities("role_parent_root_role", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Role_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Role_SyncErrors")]
		public IEnumerable<SyncError> RoleSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Role_SyncErrors", null); }
			set { SetRelatedEntities("Role_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'ModeldrivenApp'
        /// </summary>
		[RelationshipSchemaName("appmoduleroles_association")]
		public IEnumerable<ModeldrivenApp> AppmodulerolesAssociation
		{
			get { return GetRelatedEntities<ModeldrivenApp>("appmoduleroles_association", null); }
			set { SetRelatedEntities("appmoduleroles_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Privilege'
        /// </summary>
		[RelationshipSchemaName("roleprivileges_association")]
		public IEnumerable<Privilege> RoleprivilegesAssociation
		{
			get { return GetRelatedEntities<Privilege>("roleprivileges_association", null); }
			set { SetRelatedEntities("roleprivileges_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'User'
        /// </summary>
		[RelationshipSchemaName("systemuserroles_association")]
		public IEnumerable<User> SystemuserrolesAssociation
		{
			get { return GetRelatedEntities<User>("systemuserroles_association", null); }
			set { SetRelatedEntities("systemuserroles_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Team'
        /// </summary>
		[RelationshipSchemaName("teamroles_association")]
		public IEnumerable<Team> TeamrolesAssociation
		{
			get { return GetRelatedEntities<Team>("teamroles_association", null); }
			set { SetRelatedEntities("teamroles_association", null, value); }
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
		
		public enum egIsInherited
		{	
		
			[Label("Team privileges only")]
			[Description(@"")]
			TeamPrivilegesOnly = 0, 
		
			[Label("Direct User (Basic) access level and Team privileges")]
			[Description(@"")]
			DirectUserBasicAccessLevelAndTeamPrivileges = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

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
			public const string CreatedByImpersonator = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isinherited</summary>
			public const string IsInherited = "isinherited";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>parentroleid</summary>
			public const string ParentRole = "parentroleid";

			/// <summary>parentroleidname</summary>
			public const string Parentroleidname = "parentroleidname";

			/// <summary>parentrootroleid</summary>
			public const string ParentRootRole = "parentrootroleid";

			/// <summary>parentrootroleidname</summary>
			public const string Parentrootroleidname = "parentrootroleidname";

			/// <summary>roleid</summary>
			public const string RoleId = "roleid";

			/// <summary>roleidunique</summary>
			public const string UniqueId = "roleidunique";

			/// <summary>roletemplateid</summary>
			public const string RoleTemplate = "roletemplateid";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_msdyn_roleid</summary>
			public const string LkMsdynRoleid = "lk_msdyn_roleid";

			/// <summary>1:N Role_AsyncOperations</summary>
			public const string RoleAsyncOperations = "Role_AsyncOperations";

			/// <summary>1:N Role_BulkDeleteFailures</summary>
			public const string RoleBulkDeleteFailures = "Role_BulkDeleteFailures";

			/// <summary>1:N role_parent_role</summary>
			public const string RoleParentRole = "role_parent_role";

			/// <summary>1:N role_parent_root_role</summary>
			public const string RoleParentRootRole = "role_parent_root_role";

			/// <summary>1:N Role_SyncErrors</summary>
			public const string RoleSyncErrors = "Role_SyncErrors";

			/// <summary>N:N appmoduleroles_association</summary>
			public const string AppmodulerolesAssociation = "appmoduleroles_association";

			/// <summary>N:N roleprivileges_association</summary>
			public const string RoleprivilegesAssociation = "roleprivileges_association";

			/// <summary>N:N systemuserroles_association</summary>
			public const string SystemuserrolesAssociation = "systemuserroles_association";

			/// <summary>N:N teamroles_association</summary>
			public const string TeamrolesAssociation = "teamroles_association";

		}
		#endregion
	}
}

