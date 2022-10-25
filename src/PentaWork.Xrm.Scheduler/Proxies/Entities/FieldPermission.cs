using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("fieldpermission")]
	public sealed class FieldPermission : Entity
	{	
		public static readonly int? EntityTypeCode = 1201;
		public new const string LogicalName = "fieldpermission";
		public const string PrimaryIdAttribute = "fieldpermissionid";
		public const string PrimaryNameAttribute = "";
	
		public FieldPermission() : base("fieldpermission") { }

		#region Attributes
		/// <summary>
        /// attributelogicalname
        /// </summary>
		[DisplayName("Name of the attribute for which this privilege is defined")]
		[AttributeLogicalName("attributelogicalname")]
		public string NameOfTheAttributeForWhichThisPrivilegeIsDefined
		{	
			get { return GetAttributeValue<string>("attributelogicalname"); }
			set
			{ 
				if(value == NameOfTheAttributeForWhichThisPrivilegeIsDefined) return;
				SetAttributeValue("attributelogicalname", value);
			}
		}	
			
		/// <summary>
        /// cancreate
        /// </summary>
		[DisplayName("Can create the attribute")]
		[AttributeLogicalName("cancreate")]
		public egAYesOrNoBoolean? CanCreateTheAttribute
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("cancreate");
				if (optionSetValue != null) return (egAYesOrNoBoolean)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CanCreateTheAttribute) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("cancreate", optionSetValue); 
			}
		}

		/// <summary>
        /// canread
        /// </summary>
		[DisplayName("Can Read the attribute")]
		[AttributeLogicalName("canread")]
		public egAYesOrNoBoolean? CanReadTheAttribute
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("canread");
				if (optionSetValue != null) return (egAYesOrNoBoolean)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CanReadTheAttribute) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("canread", optionSetValue); 
			}
		}

		/// <summary>
        /// canupdate
        /// </summary>
		[DisplayName("Can Update the attribute")]
		[AttributeLogicalName("canupdate")]
		public egAYesOrNoBoolean? CanUpdateTheAttribute
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("canupdate");
				if (optionSetValue != null) return (egAYesOrNoBoolean)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CanUpdateTheAttribute) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("canupdate", optionSetValue); 
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
        /// entityname
        /// </summary>
		[DisplayName("Name of the Entity for which this privilege is defined")]
		[AttributeLogicalName("entityname")]
		public string NameOfTheEntityForWhichThisPrivilegeIsDefined
		{	
			get { return GetAttributeValue<string>("entityname"); }
			set
			{ 
				if(value == NameOfTheEntityForWhichThisPrivilegeIsDefined) return;
				SetAttributeValue("entityname", value);
			}
		}	
			
		/// <summary>
        /// fieldpermissionid
        /// </summary>
		[DisplayName("Field Permission")]
		[AttributeLogicalName("fieldpermissionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("fieldpermissionid", value); }
		}

							/// <summary>
        /// fieldpermissionidunique
        /// </summary>
		[DisplayName("Field Permission")]
		[AttributeLogicalName("fieldpermissionidunique")]
		public Guid FieldPermissionId2
		{	
			get { return GetAttributeValue<Guid>("fieldpermissionidunique"); }
			set
			{ 
				if(value == FieldPermissionId2) return;
				SetAttributeValue("fieldpermissionidunique", value);
			}
		}	
			
		/// <summary>
        /// fieldsecurityprofileid
        /// </summary>
		[DisplayName("Profile")]
		[AttributeLogicalName("fieldsecurityprofileid")]
		public EntityReference Profile
		{	
			get { return GetAttributeValue<EntityReference>("fieldsecurityprofileid"); }
			set
			{ 
				if(value == Profile) return;
				SetAttributeValue("fieldsecurityprofileid", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("Is Managed")]
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// 1:N Get entities for 'FieldPermission_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("FieldPermission_SyncErrors")]
		public IEnumerable<SyncError> FieldPermissionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("FieldPermission_SyncErrors", null); }
			set { SetRelatedEntities("FieldPermission_SyncErrors", null, value); }
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
		
		public enum egAYesOrNoBoolean
		{	
		
			[Label("Not Allowed")]
			[Description(@"")]
			NotAllowed = 0, 
		
			[Label("Allowed")]
			[Description(@"")]
			Allowed = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>attributelogicalname</summary>
			public const string NameOfTheAttributeForWhichThisPrivilegeIsDefined = "attributelogicalname";

			/// <summary>cancreate</summary>
			public const string CanCreateTheAttribute = "cancreate";

			/// <summary>canread</summary>
			public const string CanReadTheAttribute = "canread";

			/// <summary>canupdate</summary>
			public const string CanUpdateTheAttribute = "canupdate";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>entityname</summary>
			public const string NameOfTheEntityForWhichThisPrivilegeIsDefined = "entityname";

			/// <summary>fieldpermissionid</summary>
			public const string FieldPermissionId = "fieldpermissionid";

			/// <summary>fieldpermissionidunique</summary>
			public const string FieldPermissionId2 = "fieldpermissionidunique";

			/// <summary>fieldsecurityprofileid</summary>
			public const string Profile = "fieldsecurityprofileid";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N FieldPermission_SyncErrors</summary>
			public const string FieldPermissionSyncErrors = "FieldPermission_SyncErrors";

		}
		#endregion
	}
}

