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
	[EntityLogicalName("entitydataprovider")]
	public sealed class VirtualEntityDataProvider : Entity
	{	
		public static readonly int? EntityTypeCode = 78;
		public new const string LogicalName = "entitydataprovider";
		public const string PrimaryIdAttribute = "entitydataproviderid";
		public const string PrimaryNameAttribute = "name";
	
		public VirtualEntityDataProvider() : base("entitydataprovider") { }

		#region Attributes
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
        /// createmultipleplugin
        /// </summary>
		[DisplayName("Contains the createmultipleplugin id that should be run when CreateMultiple is invoked")]
		[AttributeLogicalName("createmultipleplugin")]
		public Guid ContainsTheCreatemultiplepluginIdThatShouldBeRunWhenCreateMultipleIsInvokedId
		{	
			get { return GetAttributeValue<Guid>("createmultipleplugin"); }
			set
			{ 
				if(value == ContainsTheCreatemultiplepluginIdThatShouldBeRunWhenCreateMultipleIsInvokedId) return;
				SetAttributeValue("createmultipleplugin", value);
			}
		}	
			
		/// <summary>
        /// createplugin
        /// </summary>
		[DisplayName("Create Plugin")]
		[AttributeLogicalName("createplugin")]
		public Guid CreatePluginId
		{	
			get { return GetAttributeValue<Guid>("createplugin"); }
			set
			{ 
				if(value == CreatePluginId) return;
				SetAttributeValue("createplugin", value);
			}
		}	
			
		/// <summary>
        /// datasourcelogicalname
        /// </summary>
		[DisplayName("Data Source Entity Logical Name")]
		[AttributeLogicalName("datasourcelogicalname")]
		public string DataSourceEntityLogicalName
		{	
			get { return GetAttributeValue<string>("datasourcelogicalname"); }
			set
			{ 
				if(value == DataSourceEntityLogicalName) return;
				SetAttributeValue("datasourcelogicalname", value);
			}
		}	
			
		/// <summary>
        /// deleteplugin
        /// </summary>
		[DisplayName("Delete Plugin")]
		[AttributeLogicalName("deleteplugin")]
		public Guid DeletePluginId
		{	
			get { return GetAttributeValue<Guid>("deleteplugin"); }
			set
			{ 
				if(value == DeletePluginId) return;
				SetAttributeValue("deleteplugin", value);
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
        /// entitydataproviderid
        /// </summary>
		[DisplayName("Data Provider")]
		[AttributeLogicalName("entitydataproviderid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entitydataproviderid", value); }
		}

							/// <summary>
        /// entitydataprovideridunique
        /// </summary>
		[DisplayName("Unique Id")]
		[AttributeLogicalName("entitydataprovideridunique")]
		public Guid UniqueId
		{	
			get { return GetAttributeValue<Guid>("entitydataprovideridunique"); }
			set
			{ 
				if(value == UniqueId) return;
				SetAttributeValue("entitydataprovideridunique", value);
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
		[DisplayName("Organization Id")]
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
        /// retrieveentitychangesplugin
        /// </summary>
		[DisplayName("Contains the retrieveentitychangesplugin id that should be run when RetrieveEntityChanges is invoked")]
		[AttributeLogicalName("retrieveentitychangesplugin")]
		public Guid ContainsTheRetrieveentitychangespluginIdThatShouldBeRunWhenRetrieveEntityChangesIsInvokedId
		{	
			get { return GetAttributeValue<Guid>("retrieveentitychangesplugin"); }
			set
			{ 
				if(value == ContainsTheRetrieveentitychangespluginIdThatShouldBeRunWhenRetrieveEntityChangesIsInvokedId) return;
				SetAttributeValue("retrieveentitychangesplugin", value);
			}
		}	
			
		/// <summary>
        /// retrievemultipleplugin
        /// </summary>
		[DisplayName("MultipleRetrieve Plugin")]
		[AttributeLogicalName("retrievemultipleplugin")]
		public Guid MultipleRetrievePluginId
		{	
			get { return GetAttributeValue<Guid>("retrievemultipleplugin"); }
			set
			{ 
				if(value == MultipleRetrievePluginId) return;
				SetAttributeValue("retrievemultipleplugin", value);
			}
		}	
			
		/// <summary>
        /// retrieveplugin
        /// </summary>
		[DisplayName("Retrieve Plugin")]
		[AttributeLogicalName("retrieveplugin")]
		public Guid RetrievePluginId
		{	
			get { return GetAttributeValue<Guid>("retrieveplugin"); }
			set
			{ 
				if(value == RetrievePluginId) return;
				SetAttributeValue("retrieveplugin", value);
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
        /// updatemultipleplugin
        /// </summary>
		[DisplayName("Contains the updatemultipleplugin id that should be run when UpdateMultiple is invoked")]
		[AttributeLogicalName("updatemultipleplugin")]
		public Guid ContainsTheUpdatemultiplepluginIdThatShouldBeRunWhenUpdateMultipleIsInvokedId
		{	
			get { return GetAttributeValue<Guid>("updatemultipleplugin"); }
			set
			{ 
				if(value == ContainsTheUpdatemultiplepluginIdThatShouldBeRunWhenUpdateMultipleIsInvokedId) return;
				SetAttributeValue("updatemultipleplugin", value);
			}
		}	
			
		/// <summary>
        /// updateplugin
        /// </summary>
		[DisplayName("Update Plugin")]
		[AttributeLogicalName("updateplugin")]
		public Guid UpdatePluginId
		{	
			get { return GetAttributeValue<Guid>("updateplugin"); }
			set
			{ 
				if(value == UpdatePluginId) return;
				SetAttributeValue("updateplugin", value);
			}
		}	
			
		/// <summary>
        /// upsertmultipleplugin
        /// </summary>
		[DisplayName("Contains the upsertmultipleplugin id that should be run when UpsertMultiple is invoked")]
		[AttributeLogicalName("upsertmultipleplugin")]
		public Guid ContainsTheUpsertmultiplepluginIdThatShouldBeRunWhenUpsertMultipleIsInvokedId
		{	
			get { return GetAttributeValue<Guid>("upsertmultipleplugin"); }
			set
			{ 
				if(value == ContainsTheUpsertmultiplepluginIdThatShouldBeRunWhenUpsertMultipleIsInvokedId) return;
				SetAttributeValue("upsertmultipleplugin", value);
			}
		}	
			
		/// <summary>
        /// upsertplugin
        /// </summary>
		[DisplayName("Contains the upsertplugin id that should be run when Upsert is invoked")]
		[AttributeLogicalName("upsertplugin")]
		public Guid ContainsTheUpsertpluginIdThatShouldBeRunWhenUpsertIsInvokedId
		{	
			get { return GetAttributeValue<Guid>("upsertplugin"); }
			set
			{ 
				if(value == ContainsTheUpsertpluginIdThatShouldBeRunWhenUpsertIsInvokedId) return;
				SetAttributeValue("upsertplugin", value);
			}
		}	
			
		#endregion	

		#region Relations
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
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>createmultipleplugin</summary>
			public const string ContainsTheCreatemultiplepluginIdThatShouldBeRunWhenCreateMultipleIsInvokedId = "createmultipleplugin";

			/// <summary>createplugin</summary>
			public const string CreatePluginId = "createplugin";

			/// <summary>datasourcelogicalname</summary>
			public const string DataSourceEntityLogicalName = "datasourcelogicalname";

			/// <summary>deleteplugin</summary>
			public const string DeletePluginId = "deleteplugin";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>entitydataproviderid</summary>
			public const string DataProviderId = "entitydataproviderid";

			/// <summary>entitydataprovideridunique</summary>
			public const string UniqueId = "entitydataprovideridunique";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>retrieveentitychangesplugin</summary>
			public const string ContainsTheRetrieveentitychangespluginIdThatShouldBeRunWhenRetrieveEntityChangesIsInvokedId = "retrieveentitychangesplugin";

			/// <summary>retrievemultipleplugin</summary>
			public const string MultipleRetrievePluginId = "retrievemultipleplugin";

			/// <summary>retrieveplugin</summary>
			public const string RetrievePluginId = "retrieveplugin";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>updatemultipleplugin</summary>
			public const string ContainsTheUpdatemultiplepluginIdThatShouldBeRunWhenUpdateMultipleIsInvokedId = "updatemultipleplugin";

			/// <summary>updateplugin</summary>
			public const string UpdatePluginId = "updateplugin";

			/// <summary>upsertmultipleplugin</summary>
			public const string ContainsTheUpsertmultiplepluginIdThatShouldBeRunWhenUpsertMultipleIsInvokedId = "upsertmultipleplugin";

			/// <summary>upsertplugin</summary>
			public const string ContainsTheUpsertpluginIdThatShouldBeRunWhenUpsertIsInvokedId = "upsertplugin";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

