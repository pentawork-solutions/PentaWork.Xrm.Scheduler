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
	[EntityLogicalName("roletemplate")]
	public sealed class RoleTemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 1037;
		public new const string LogicalName = "roletemplate";
		public const string PrimaryIdAttribute = "roletemplateid";
		public const string PrimaryNameAttribute = "name";
	
		public RoleTemplate() : base("roletemplate") { }

		#region Attributes
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("name")]
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
        /// roletemplateid
        /// </summary>
		[DisplayName("roletemplateid")]
		[AttributeLogicalName("roletemplateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("roletemplateid", value); }
		}

							/// <summary>
        /// upgrading
        /// </summary>
		[DisplayName("upgrading")]
		[AttributeLogicalName("upgrading")]
		public bool? Upgrading
		{	
			get { return GetAttributeValue<bool?>("upgrading"); }
			set
			{ 
				if(value == Upgrading) return;
				SetAttributeValue("upgrading", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'role_template_roles'
        /// </summary>
		[RelationshipSchemaName("role_template_roles")]
		public IEnumerable<SecurityRole> RoleTemplateRoles
		{
			get { return GetRelatedEntities<SecurityRole>("role_template_roles", null); }
			set { SetRelatedEntities("role_template_roles", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Privilege'
        /// </summary>
		[RelationshipSchemaName("roletemplateprivileges_association")]
		public IEnumerable<Privilege> RoletemplateprivilegesAssociation
		{
			get { return GetRelatedEntities<Privilege>("roletemplateprivileges_association", null); }
			set { SetRelatedEntities("roletemplateprivileges_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>roletemplateid</summary>
			public const string RoletemplateId = "roletemplateid";

			/// <summary>upgrading</summary>
			public const string Upgrading = "upgrading";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N role_template_roles</summary>
			public const string RoleTemplateRoles = "role_template_roles";

			/// <summary>N:N roletemplateprivileges_association</summary>
			public const string RoletemplateprivilegesAssociation = "roletemplateprivileges_association";

		}
		#endregion
	}
}

