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
	[EntityLogicalName("privilege")]
	public sealed class Privilege : Entity
	{	
		public static readonly int? EntityTypeCode = 1023;
		public new const string LogicalName = "privilege";
		public const string PrimaryIdAttribute = "privilegeid";
		public const string PrimaryNameAttribute = "name";
	
		public Privilege() : base("privilege") { }

		#region Attributes
		/// <summary>
        /// accessright
        /// </summary>
		[DisplayName("accessright")]
		[AttributeLogicalName("accessright")]
		public int? Accessright
		{	
			get { return GetAttributeValue<int?>("accessright"); }
			set
			{ 
				if(value == Accessright) return;
				SetAttributeValue("accessright", value);
			}
		}	
			
		/// <summary>
        /// canbebasic
        /// </summary>
		[DisplayName("canbebasic")]
		[AttributeLogicalName("canbebasic")]
		public bool? Canbebasic
		{	
			get { return GetAttributeValue<bool?>("canbebasic"); }
			set
			{ 
				if(value == Canbebasic) return;
				SetAttributeValue("canbebasic", value);
			}
		}	
			
		/// <summary>
        /// canbedeep
        /// </summary>
		[DisplayName("canbedeep")]
		[AttributeLogicalName("canbedeep")]
		public bool? Canbedeep
		{	
			get { return GetAttributeValue<bool?>("canbedeep"); }
			set
			{ 
				if(value == Canbedeep) return;
				SetAttributeValue("canbedeep", value);
			}
		}	
			
		/// <summary>
        /// canbeentityreference
        /// </summary>
		[DisplayName("canbeentityreference")]
		[AttributeLogicalName("canbeentityreference")]
		public bool? Canbeentityreference
		{	
			get { return GetAttributeValue<bool?>("canbeentityreference"); }
			set
			{ 
				if(value == Canbeentityreference) return;
				SetAttributeValue("canbeentityreference", value);
			}
		}	
			
		/// <summary>
        /// canbeglobal
        /// </summary>
		[DisplayName("canbeglobal")]
		[AttributeLogicalName("canbeglobal")]
		public bool? Canbeglobal
		{	
			get { return GetAttributeValue<bool?>("canbeglobal"); }
			set
			{ 
				if(value == Canbeglobal) return;
				SetAttributeValue("canbeglobal", value);
			}
		}	
			
		/// <summary>
        /// canbelocal
        /// </summary>
		[DisplayName("canbelocal")]
		[AttributeLogicalName("canbelocal")]
		public bool? Canbelocal
		{	
			get { return GetAttributeValue<bool?>("canbelocal"); }
			set
			{ 
				if(value == Canbelocal) return;
				SetAttributeValue("canbelocal", value);
			}
		}	
			
		/// <summary>
        /// canbeparententityreference
        /// </summary>
		[DisplayName("canbeparententityreference")]
		[AttributeLogicalName("canbeparententityreference")]
		public bool? Canbeparententityreference
		{	
			get { return GetAttributeValue<bool?>("canbeparententityreference"); }
			set
			{ 
				if(value == Canbeparententityreference) return;
				SetAttributeValue("canbeparententityreference", value);
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
        /// isdisabledwhenintegrated
        /// </summary>
		[DisplayName("isdisabledwhenintegrated")]
		[AttributeLogicalName("isdisabledwhenintegrated")]
		public bool? Isdisabledwhenintegrated
		{	
			get { return GetAttributeValue<bool?>("isdisabledwhenintegrated"); }
			set
			{ 
				if(value == Isdisabledwhenintegrated) return;
				SetAttributeValue("isdisabledwhenintegrated", value);
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
        /// privilegeid
        /// </summary>
		[DisplayName("privilegeid")]
		[AttributeLogicalName("privilegeid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("privilegeid", value); }
		}

							/// <summary>
        /// privilegerowid
        /// </summary>
		[DisplayName("App Module Unique Id")]
		[AttributeLogicalName("privilegerowid")]
		public Guid AppModuleUniqueId
		{	
			get { return GetAttributeValue<Guid>("privilegerowid"); }
			set
			{ 
				if(value == AppModuleUniqueId) return;
				SetAttributeValue("privilegerowid", value);
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
        /// 1:N Get entities for 'Privilege_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Privilege_AsyncOperations")]
		public IEnumerable<SystemJob> PrivilegeAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Privilege_AsyncOperations", null); }
			set { SetRelatedEntities("Privilege_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Privilege_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Privilege_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> PrivilegeBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Privilege_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Privilege_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SecurityRole'
        /// </summary>
		[RelationshipSchemaName("roleprivileges_association")]
		public IEnumerable<SecurityRole> RoleprivilegesAssociation
		{
			get { return GetRelatedEntities<SecurityRole>("roleprivileges_association", null); }
			set { SetRelatedEntities("roleprivileges_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'RoleTemplate'
        /// </summary>
		[RelationshipSchemaName("roletemplateprivileges_association")]
		public IEnumerable<RoleTemplate> RoletemplateprivilegesAssociation
		{
			get { return GetRelatedEntities<RoleTemplate>("roletemplateprivileges_association", null); }
			set { SetRelatedEntities("roletemplateprivileges_association", null, value); }
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
			/// <summary>accessright</summary>
			public const string Accessright = "accessright";

			/// <summary>canbebasic</summary>
			public const string Canbebasic = "canbebasic";

			/// <summary>canbedeep</summary>
			public const string Canbedeep = "canbedeep";

			/// <summary>canbeentityreference</summary>
			public const string Canbeentityreference = "canbeentityreference";

			/// <summary>canbeglobal</summary>
			public const string Canbeglobal = "canbeglobal";

			/// <summary>canbelocal</summary>
			public const string Canbelocal = "canbelocal";

			/// <summary>canbeparententityreference</summary>
			public const string Canbeparententityreference = "canbeparententityreference";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isdisabledwhenintegrated</summary>
			public const string Isdisabledwhenintegrated = "isdisabledwhenintegrated";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>privilegeid</summary>
			public const string PrivilegeId = "privilegeid";

			/// <summary>privilegerowid</summary>
			public const string AppModuleUniqueId = "privilegerowid";

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
			/// <summary>1:N Privilege_AsyncOperations</summary>
			public const string PrivilegeAsyncOperations = "Privilege_AsyncOperations";

			/// <summary>1:N Privilege_BulkDeleteFailures</summary>
			public const string PrivilegeBulkDeleteFailures = "Privilege_BulkDeleteFailures";

			/// <summary>N:N roleprivileges_association</summary>
			public const string RoleprivilegesAssociation = "roleprivileges_association";

			/// <summary>N:N roletemplateprivileges_association</summary>
			public const string RoletemplateprivilegesAssociation = "roletemplateprivileges_association";

		}
		#endregion
	}
}

