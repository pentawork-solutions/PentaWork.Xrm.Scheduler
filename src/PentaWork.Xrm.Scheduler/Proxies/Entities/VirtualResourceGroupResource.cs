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
	[EntityLogicalName("virtualresourcegroupresource")]
	public sealed class VirtualResourceGroupResource : Entity
	{	
		public static readonly int? EntityTypeCode = 10075;
		public new const string LogicalName = "virtualresourcegroupresource";
		public const string PrimaryIdAttribute = "virtualresourcegroupresourceid";
		public const string PrimaryNameAttribute = "name";
	
		public VirtualResourceGroupResource() : base("virtualresourcegroupresource") { }

		#region Attributes
		/// <summary>
        /// businessunit
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunit")]
		public string BusinessUnit
		{	
			get { return GetAttributeValue<string>("businessunit"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunit", value);
			}
		}	
			
		/// <summary>
        /// constraintbasedgroupid
        /// </summary>
		[DisplayName("constraintbasedgroupid")]
		[AttributeLogicalName("constraintbasedgroupid")]
		public string Constraintbasedgroupid
		{	
			get { return GetAttributeValue<string>("constraintbasedgroupid"); }
			set
			{ 
				if(value == Constraintbasedgroupid) return;
				SetAttributeValue("constraintbasedgroupid", value);
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
        /// resourceentitylogicalname
        /// </summary>
		[DisplayName("Entity type logical name")]
		[AttributeLogicalName("resourceentitylogicalname")]
		public string EntityTypeLogicalName
		{	
			get { return GetAttributeValue<string>("resourceentitylogicalname"); }
			set
			{ 
				if(value == EntityTypeLogicalName) return;
				SetAttributeValue("resourceentitylogicalname", value);
			}
		}	
			
		/// <summary>
        /// resourceentityname
        /// </summary>
		[DisplayName("Entity Type")]
		[AttributeLogicalName("resourceentityname")]
		public string EntityType
		{	
			get { return GetAttributeValue<string>("resourceentityname"); }
			set
			{ 
				if(value == EntityType) return;
				SetAttributeValue("resourceentityname", value);
			}
		}	
			
		/// <summary>
        /// resourcegroupid
        /// </summary>
		[DisplayName("resourcegroup")]
		[AttributeLogicalName("resourcegroupid")]
		public EntityReference Resourcegroup
		{	
			get { return GetAttributeValue<EntityReference>("resourcegroupid"); }
			set
			{ 
				if(value == Resourcegroup) return;
				SetAttributeValue("resourcegroupid", value);
			}
		}	
			
		/// <summary>
        /// resourcegroupidname
        /// </summary>
		[DisplayName("resourcegroupidname")]
		[AttributeLogicalName("resourcegroupidname")]
		public string Resourcegroupidname
		{	
			get { return GetAttributeValue<string>("resourcegroupidname"); }
			set
			{ 
				if(value == Resourcegroupidname) return;
				SetAttributeValue("resourcegroupidname", value);
			}
		}	
			
		/// <summary>
        /// virtualresourcegroupresourceid
        /// </summary>
		[DisplayName("virtualresourcegroupresource")]
		[AttributeLogicalName("virtualresourcegroupresourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("virtualresourcegroupresourceid", value); }
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
			/// <summary>businessunit</summary>
			public const string BusinessUnit = "businessunit";

			/// <summary>constraintbasedgroupid</summary>
			public const string Constraintbasedgroupid = "constraintbasedgroupid";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>resourceentitylogicalname</summary>
			public const string EntityTypeLogicalName = "resourceentitylogicalname";

			/// <summary>resourceentityname</summary>
			public const string EntityType = "resourceentityname";

			/// <summary>resourcegroupid</summary>
			public const string Resourcegroup = "resourcegroupid";

			/// <summary>resourcegroupidname</summary>
			public const string Resourcegroupidname = "resourcegroupidname";

			/// <summary>virtualresourcegroupresourceid</summary>
			public const string VirtualresourcegroupresourceId = "virtualresourcegroupresourceid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

