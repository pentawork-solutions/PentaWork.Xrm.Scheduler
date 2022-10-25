using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("principalobjectattributeaccess")]
	public sealed class FieldSharing : Entity
	{	
		public static readonly int? EntityTypeCode = 44;
		public new const string LogicalName = "principalobjectattributeaccess";
		public const string PrimaryIdAttribute = "principalobjectattributeaccessid";
		public const string PrimaryNameAttribute = "";
	
		public FieldSharing() : base("principalobjectattributeaccess") { }

		#region Attributes
		/// <summary>
        /// attributeid
        /// </summary>
		[DisplayName("Secured field")]
		[AttributeLogicalName("attributeid")]
		public Guid SecuredFieldId
		{	
			get { return GetAttributeValue<Guid>("attributeid"); }
			set
			{ 
				if(value == SecuredFieldId) return;
				SetAttributeValue("attributeid", value);
			}
		}	
			
		/// <summary>
        /// objectid
        /// </summary>
		[DisplayName("Entity instance")]
		[AttributeLogicalName("objectid")]
		public EntityReference EntityInstance
		{	
			get { return GetAttributeValue<EntityReference>("objectid"); }
			set
			{ 
				if(value == EntityInstance) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Entity object type")]
		[AttributeLogicalName("objecttypecode")]
		public string EntityObjectType
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == EntityObjectType) return;
				SetAttributeValue("objecttypecode", value);
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
        /// principalid
        /// </summary>
		[DisplayName("Principal")]
		[AttributeLogicalName("principalid")]
		public EntityReference Principal
		{	
			get { return GetAttributeValue<EntityReference>("principalid"); }
			set
			{ 
				if(value == Principal) return;
				SetAttributeValue("principalid", value);
			}
		}	
			
		/// <summary>
        /// principalidname
        /// </summary>
		[DisplayName("principalidname")]
		[AttributeLogicalName("principalidname")]
		public string Principalidname
		{	
			get { return GetAttributeValue<string>("principalidname"); }
			set
			{ 
				if(value == Principalidname) return;
				SetAttributeValue("principalidname", value);
			}
		}	
			
		/// <summary>
        /// principalidtype
        /// </summary>
		[DisplayName("Principal type")]
		[AttributeLogicalName("principalidtype")]
		public string PrincipalType
		{	
			get { return GetAttributeValue<string>("principalidtype"); }
			set
			{ 
				if(value == PrincipalType) return;
				SetAttributeValue("principalidtype", value);
			}
		}	
			
		/// <summary>
        /// principalobjectattributeaccessid
        /// </summary>
		[DisplayName("Shared secured field")]
		[AttributeLogicalName("principalobjectattributeaccessid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("principalobjectattributeaccessid", value); }
		}

							/// <summary>
        /// readaccess
        /// </summary>
		[DisplayName("Read permission")]
		[AttributeLogicalName("readaccess")]
		public bool? ReadPermission
		{	
			get { return GetAttributeValue<bool?>("readaccess"); }
			set
			{ 
				if(value == ReadPermission) return;
				SetAttributeValue("readaccess", value);
			}
		}	
			
		/// <summary>
        /// updateaccess
        /// </summary>
		[DisplayName("Update permission")]
		[AttributeLogicalName("updateaccess")]
		public bool? UpdatePermission
		{	
			get { return GetAttributeValue<bool?>("updateaccess"); }
			set
			{ 
				if(value == UpdatePermission) return;
				SetAttributeValue("updateaccess", value);
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
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>attributeid</summary>
			public const string SecuredFieldId = "attributeid";

			/// <summary>objectid</summary>
			public const string EntityInstance = "objectid";

			/// <summary>objecttypecode</summary>
			public const string EntityObjectType = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>principalid</summary>
			public const string Principal = "principalid";

			/// <summary>principalidname</summary>
			public const string Principalidname = "principalidname";

			/// <summary>principalidtype</summary>
			public const string PrincipalType = "principalidtype";

			/// <summary>principalobjectattributeaccessid</summary>
			public const string SharedSecuredFieldId = "principalobjectattributeaccessid";

			/// <summary>readaccess</summary>
			public const string ReadPermission = "readaccess";

			/// <summary>updateaccess</summary>
			public const string UpdatePermission = "updateaccess";

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

