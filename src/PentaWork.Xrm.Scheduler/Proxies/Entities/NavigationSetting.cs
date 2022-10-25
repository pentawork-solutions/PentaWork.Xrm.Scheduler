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
	[EntityLogicalName("navigationsetting")]
	public sealed class NavigationSetting : Entity
	{	
		public static readonly int? EntityTypeCode = 9900;
		public new const string LogicalName = "navigationsetting";
		public const string PrimaryIdAttribute = "navigationsettingid";
		public const string PrimaryNameAttribute = "name";
	
		public NavigationSetting() : base("navigationsetting") { }

		#region Attributes
		/// <summary>
        /// advancedsettingorder
        /// </summary>
		[DisplayName("AdvancedOrder")]
		[AttributeLogicalName("advancedsettingorder")]
		public int? AdvancedOrder
		{	
			get { return GetAttributeValue<int?>("advancedsettingorder"); }
			set
			{ 
				if(value == AdvancedOrder) return;
				SetAttributeValue("advancedsettingorder", value);
			}
		}	
			
		/// <summary>
        /// appconfigid
        /// </summary>
		[DisplayName("AppConfigId")]
		[AttributeLogicalName("appconfigid")]
		public EntityReference AppConfigId
		{	
			get { return GetAttributeValue<EntityReference>("appconfigid"); }
			set
			{ 
				if(value == AppConfigId) return;
				SetAttributeValue("appconfigid", value);
			}
		}	
			
		/// <summary>
        /// appconfigidunique
        /// </summary>
		[DisplayName("AppConfigIdUnique")]
		[AttributeLogicalName("appconfigidunique")]
		public Guid AppConfigIdUniqueId
		{	
			get { return GetAttributeValue<Guid>("appconfigidunique"); }
			set
			{ 
				if(value == AppConfigIdUniqueId) return;
				SetAttributeValue("appconfigidunique", value);
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
        /// groupname
        /// </summary>
		[DisplayName("Group Name")]
		[AttributeLogicalName("groupname")]
		public string GroupName
		{	
			get { return GetAttributeValue<string>("groupname"); }
			set
			{ 
				if(value == GroupName) return;
				SetAttributeValue("groupname", value);
			}
		}	
			
		/// <summary>
        /// iconresourceid
        /// </summary>
		[DisplayName("IconResourceId")]
		[AttributeLogicalName("iconresourceid")]
		public Guid IconResourceId
		{	
			get { return GetAttributeValue<Guid>("iconresourceid"); }
			set
			{ 
				if(value == IconResourceId) return;
				SetAttributeValue("iconresourceid", value);
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
        /// navigationsettingid
        /// </summary>
		[DisplayName("NavigationSettingId")]
		[AttributeLogicalName("navigationsettingid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("navigationsettingid", value); }
		}

							/// <summary>
        /// navigationsettingidunique
        /// </summary>
		[DisplayName("NavigationSettingIdUnique")]
		[AttributeLogicalName("navigationsettingidunique")]
		public Guid NavigationSettingIdUniqueId
		{	
			get { return GetAttributeValue<Guid>("navigationsettingidunique"); }
			set
			{ 
				if(value == NavigationSettingIdUniqueId) return;
				SetAttributeValue("navigationsettingidunique", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("EntityObjectTypeCode")]
		[AttributeLogicalName("objecttypecode")]
		public int? EntityObjectTypeCode
		{	
			get { return GetAttributeValue<int?>("objecttypecode"); }
			set
			{ 
				if(value == EntityObjectTypeCode) return;
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
        /// pageurl
        /// </summary>
		[DisplayName("Page Url")]
		[AttributeLogicalName("pageurl")]
		public string PageUrl
		{	
			get { return GetAttributeValue<string>("pageurl"); }
			set
			{ 
				if(value == PageUrl) return;
				SetAttributeValue("pageurl", value);
			}
		}	
			
		/// <summary>
        /// parentnavigationsettingid
        /// </summary>
		[DisplayName("Parent Navigation Setting Id")]
		[AttributeLogicalName("parentnavigationsettingid")]
		public Guid ParentNavigationSettingId
		{	
			get { return GetAttributeValue<Guid>("parentnavigationsettingid"); }
			set
			{ 
				if(value == ParentNavigationSettingId) return;
				SetAttributeValue("parentnavigationsettingid", value);
			}
		}	
			
		/// <summary>
        /// privileges
        /// </summary>
		[DisplayName("Privileges")]
		[AttributeLogicalName("privileges")]
		public int? Privileges
		{	
			get { return GetAttributeValue<int?>("privileges"); }
			set
			{ 
				if(value == Privileges) return;
				SetAttributeValue("privileges", value);
			}
		}	
			
		/// <summary>
        /// progressstate
        /// </summary>
		[DisplayName("Progress State")]
		[AttributeLogicalName("progressstate")]
		public bool? ProgressState
		{	
			get { return GetAttributeValue<bool?>("progressstate"); }
			set
			{ 
				if(value == ProgressState) return;
				SetAttributeValue("progressstate", value);
			}
		}	
			
		/// <summary>
        /// quicksettingorder
        /// </summary>
		[DisplayName("QuickOrder")]
		[AttributeLogicalName("quicksettingorder")]
		public int? QuickOrder
		{	
			get { return GetAttributeValue<int?>("quicksettingorder"); }
			set
			{ 
				if(value == QuickOrder) return;
				SetAttributeValue("quicksettingorder", value);
			}
		}	
			
		/// <summary>
        /// resourceid
        /// </summary>
		[DisplayName("Resource Id")]
		[AttributeLogicalName("resourceid")]
		public Guid ResourceId
		{	
			get { return GetAttributeValue<Guid>("resourceid"); }
			set
			{ 
				if(value == ResourceId) return;
				SetAttributeValue("resourceid", value);
			}
		}	
			
		/// <summary>
        /// settingtype
        /// </summary>
		[DisplayName("Group Type")]
		[AttributeLogicalName("settingtype")]
		public eNavigationsettingSettingtype? GroupType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("settingtype");
				if (optionSetValue != null) return (eNavigationsettingSettingtype)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == GroupType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("settingtype", optionSetValue); 
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
		
		public enum eNavigationsettingSettingtype
		{	
		
			[Label("Advanced Setup")]
			[Description(@"")]
			AdvancedSetup = 0, 
		
			[Label("Basic Setup")]
			[Description(@"")]
			BasicSetup = 1, 
		
			[Label("Advanced Setup Summary")]
			[Description(@"")]
			AdvancedSetupSummary = 2, 
		
			[Label("Basic Setup Summary")]
			[Description(@"")]
			BasicSetupSummary = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>advancedsettingorder</summary>
			public const string AdvancedOrder = "advancedsettingorder";

			/// <summary>appconfigid</summary>
			public const string AppConfigId = "appconfigid";

			/// <summary>appconfigidunique</summary>
			public const string AppConfigIdUniqueId = "appconfigidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>groupname</summary>
			public const string GroupName = "groupname";

			/// <summary>iconresourceid</summary>
			public const string IconResourceId = "iconresourceid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

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

			/// <summary>navigationsettingid</summary>
			public const string NavigationSettingId = "navigationsettingid";

			/// <summary>navigationsettingidunique</summary>
			public const string NavigationSettingIdUniqueId = "navigationsettingidunique";

			/// <summary>objecttypecode</summary>
			public const string EntityObjectTypeCode = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>pageurl</summary>
			public const string PageUrl = "pageurl";

			/// <summary>parentnavigationsettingid</summary>
			public const string ParentNavigationSettingId = "parentnavigationsettingid";

			/// <summary>privileges</summary>
			public const string Privileges = "privileges";

			/// <summary>progressstate</summary>
			public const string ProgressState = "progressstate";

			/// <summary>quicksettingorder</summary>
			public const string QuickOrder = "quicksettingorder";

			/// <summary>resourceid</summary>
			public const string ResourceId = "resourceid";

			/// <summary>settingtype</summary>
			public const string GroupType = "settingtype";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

