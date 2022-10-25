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
	[EntityLogicalName("systemform")]
	public sealed class SystemForm : Entity
	{	
		public static readonly int? EntityTypeCode = 1030;
		public new const string LogicalName = "systemform";
		public const string PrimaryIdAttribute = "formid";
		public const string PrimaryNameAttribute = "name";
	
		public SystemForm() : base("systemform") { }

		#region Attributes
		/// <summary>
        /// ancestorformid
        /// </summary>
		[DisplayName("Parent Form")]
		[AttributeLogicalName("ancestorformid")]
		public EntityReference ParentForm
		{	
			get { return GetAttributeValue<EntityReference>("ancestorformid"); }
			set
			{ 
				if(value == ParentForm) return;
				SetAttributeValue("ancestorformid", value);
			}
		}	
			
		/// <summary>
        /// ancestorformidname
        /// </summary>
		[DisplayName("ancestorformidname")]
		[AttributeLogicalName("ancestorformidname")]
		public string Ancestorformidname
		{	
			get { return GetAttributeValue<string>("ancestorformidname"); }
			set
			{ 
				if(value == Ancestorformidname) return;
				SetAttributeValue("ancestorformidname", value);
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
        /// formactivationstate
        /// </summary>
		[DisplayName("Form State")]
		[AttributeLogicalName("formactivationstate")]
		public eFormState? FormState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("formactivationstate");
				if (optionSetValue != null) return (eFormState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FormState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("formactivationstate", optionSetValue); 
			}
		}

		/// <summary>
        /// formid
        /// </summary>
		[DisplayName("formid")]
		[AttributeLogicalName("formid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("formid", value); }
		}

							/// <summary>
        /// formidunique
        /// </summary>
		[DisplayName("formidunique")]
		[AttributeLogicalName("formidunique")]
		public Guid FormiduniqueId
		{	
			get { return GetAttributeValue<Guid>("formidunique"); }
			set
			{ 
				if(value == FormiduniqueId) return;
				SetAttributeValue("formidunique", value);
			}
		}	
			
		/// <summary>
        /// formjson
        /// </summary>
		[DisplayName("formjson")]
		[AttributeLogicalName("formjson")]
		public string Formjson
		{	
			get { return GetAttributeValue<string>("formjson"); }
			set
			{ 
				if(value == Formjson) return;
				SetAttributeValue("formjson", value);
			}
		}	
			
		/// <summary>
        /// formpresentation
        /// </summary>
		[DisplayName("AIR Refreshed")]
		[AttributeLogicalName("formpresentation")]
		public eRefreshedLayout? AIRRefreshed
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("formpresentation");
				if (optionSetValue != null) return (eRefreshedLayout)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AIRRefreshed) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("formpresentation", optionSetValue); 
			}
		}

		/// <summary>
        /// formxml
        /// </summary>
		[DisplayName("formxml")]
		[AttributeLogicalName("formxml")]
		public string Formxml
		{	
			get { return GetAttributeValue<string>("formxml"); }
			set
			{ 
				if(value == Formxml) return;
				SetAttributeValue("formxml", value);
			}
		}	
			
		/// <summary>
        /// formxmlmanaged
        /// </summary>
		[DisplayName("formxmlmanaged")]
		[AttributeLogicalName("formxmlmanaged")]
		public string Formxmlmanaged
		{	
			get { return GetAttributeValue<string>("formxmlmanaged"); }
			set
			{ 
				if(value == Formxmlmanaged) return;
				SetAttributeValue("formxmlmanaged", value);
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
        /// isairmerged
        /// </summary>
		[DisplayName("Refreshed")]
		[AttributeLogicalName("isairmerged")]
		public bool? Refreshed
		{	
			get { return GetAttributeValue<bool?>("isairmerged"); }
			set
			{ 
				if(value == Refreshed) return;
				SetAttributeValue("isairmerged", value);
			}
		}	
			
		/// <summary>
        /// isdefault
        /// </summary>
		[DisplayName("Default Form")]
		[AttributeLogicalName("isdefault")]
		public bool? DefaultForm
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == DefaultForm) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// isdesktopenabled
        /// </summary>
		[DisplayName("Is Desktop Enabled")]
		[AttributeLogicalName("isdesktopenabled")]
		public bool? IsDesktopEnabled
		{	
			get { return GetAttributeValue<bool?>("isdesktopenabled"); }
			set
			{ 
				if(value == IsDesktopEnabled) return;
				SetAttributeValue("isdesktopenabled", value);
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
        /// istabletenabled
        /// </summary>
		[DisplayName("Is Tablet Enabled")]
		[AttributeLogicalName("istabletenabled")]
		public bool? IsTabletEnabled
		{	
			get { return GetAttributeValue<bool?>("istabletenabled"); }
			set
			{ 
				if(value == IsTabletEnabled) return;
				SetAttributeValue("istabletenabled", value);
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
        /// objecttypecode
        /// </summary>
		[DisplayName("Entity Name")]
		[AttributeLogicalName("objecttypecode")]
		public string EntityName
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == EntityName) return;
				SetAttributeValue("objecttypecode", value);
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
        /// type
        /// </summary>
		[DisplayName("Form Type")]
		[AttributeLogicalName("type")]
		public eType? FormType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FormType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
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
        /// version
        /// </summary>
		[DisplayName("version")]
		[AttributeLogicalName("version")]
		public int? Version
		{	
			get { return GetAttributeValue<int?>("version"); }
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
        /// 1:N Get entities for 'form_ancestor_form'
        /// </summary>
		[RelationshipSchemaName("form_ancestor_form")]
		public IEnumerable<SystemForm> FormAncestorForm
		{
			get { return GetRelatedEntities<SystemForm>("form_ancestor_form", null); }
			set { SetRelatedEntities("form_ancestor_form", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processtrigger_systemform'
        /// </summary>
		[RelationshipSchemaName("processtrigger_systemform")]
		public IEnumerable<ProcessTrigger> ProcesstriggerSystemform
		{
			get { return GetRelatedEntities<ProcessTrigger>("processtrigger_systemform", null); }
			set { SetRelatedEntities("processtrigger_systemform", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemForm_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SystemForm_AsyncOperations")]
		public IEnumerable<SystemJob> SystemFormAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SystemForm_AsyncOperations", null); }
			set { SetRelatedEntities("SystemForm_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemForm_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SystemForm_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SystemFormBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SystemForm_BulkDeleteFailures", null, value); }
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
		
		public enum eFormState
		{	
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 0, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 1, 
		}
		
		public enum eRefreshedLayout
		{	
		
			[Label("ClassicForm")]
			[Description(@"")]
			ClassicForm = 0, 
		
			[Label("AirForm")]
			[Description(@"")]
			AirForm = 1, 
		
			[Label("ConvertedICForm")]
			[Description(@"")]
			ConvertedICForm = 2, 
		}
		
		public enum eType
		{	
		
			[Label("Dashboard")]
			[Description(@"")]
			Dashboard = 0, 
		
			[Label("AppointmentBook")]
			[Description(@"")]
			AppointmentBook = 1, 
		
			[Label("Main")]
			[Description(@"")]
			Main = 2, 
		
			[Label("MiniCampaignBO")]
			[Description(@"")]
			MiniCampaignBO = 3, 
		
			[Label("Preview")]
			[Description(@"")]
			Preview = 4, 
		
			[Label("Mobile - Express")]
			[Description(@"")]
			MobileExpress = 5, 
		
			[Label("Quick View Form")]
			[Description(@"")]
			QuickViewForm = 6, 
		
			[Label("Quick Create")]
			[Description(@"")]
			QuickCreate = 7, 
		
			[Label("Dialog")]
			[Description(@"")]
			Dialog = 8, 
		
			[Label("Task Flow Form")]
			[Description(@"")]
			TaskFlowForm = 9, 
		
			[Label("InteractionCentricDashboard")]
			[Description(@"")]
			InteractionCentricDashboard = 10, 
		
			[Label("Card")]
			[Description(@"")]
			Card = 11, 
		
			[Label("Main - Interactive experience")]
			[Description(@"")]
			MainInteractiveExperience = 12, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 100, 
		
			[Label("MainBackup")]
			[Description(@"")]
			MainBackup = 101, 
		
			[Label("AppointmentBookBackup")]
			[Description(@"")]
			AppointmentBookBackup = 102, 
		
			[Label("Power BI Dashboard")]
			[Description(@"")]
			PowerBIDashboard = 103, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>ancestorformid</summary>
			public const string ParentForm = "ancestorformid";

			/// <summary>ancestorformidname</summary>
			public const string Ancestorformidname = "ancestorformidname";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>formactivationstate</summary>
			public const string FormState = "formactivationstate";

			/// <summary>formid</summary>
			public const string FormId = "formid";

			/// <summary>formidunique</summary>
			public const string FormiduniqueId = "formidunique";

			/// <summary>formjson</summary>
			public const string Formjson = "formjson";

			/// <summary>formpresentation</summary>
			public const string AIRRefreshed = "formpresentation";

			/// <summary>formxml</summary>
			public const string Formxml = "formxml";

			/// <summary>formxmlmanaged</summary>
			public const string Formxmlmanaged = "formxmlmanaged";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isairmerged</summary>
			public const string Refreshed = "isairmerged";

			/// <summary>isdefault</summary>
			public const string DefaultForm = "isdefault";

			/// <summary>isdesktopenabled</summary>
			public const string IsDesktopEnabled = "isdesktopenabled";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>istabletenabled</summary>
			public const string IsTabletEnabled = "istabletenabled";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>objecttypecode</summary>
			public const string EntityName = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organizationid = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>publishedon</summary>
			public const string PublishedOn = "publishedon";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>type</summary>
			public const string FormType = "type";

			/// <summary>uniquename</summary>
			public const string UniqueName = "uniquename";

			/// <summary>version</summary>
			public const string Version = "version";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N form_ancestor_form</summary>
			public const string FormAncestorForm = "form_ancestor_form";

			/// <summary>1:N processtrigger_systemform</summary>
			public const string ProcesstriggerSystemform = "processtrigger_systemform";

			/// <summary>1:N SystemForm_AsyncOperations</summary>
			public const string SystemFormAsyncOperations = "SystemForm_AsyncOperations";

			/// <summary>1:N SystemForm_BulkDeleteFailures</summary>
			public const string SystemFormBulkDeleteFailures = "SystemForm_BulkDeleteFailures";

		}
		#endregion
	}
}

