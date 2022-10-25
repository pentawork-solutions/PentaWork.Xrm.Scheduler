using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("appmodulecomponent")]
	public sealed class AppModuleComponent : Entity
	{	
		public static readonly int? EntityTypeCode = 9007;
		public new const string LogicalName = "appmodulecomponent";
		public const string PrimaryIdAttribute = "appmodulecomponentid";
		public const string PrimaryNameAttribute = "";
	
		public AppModuleComponent() : base("appmodulecomponent") { }

		#region Attributes
		/// <summary>
        /// appmodulecomponentid
        /// </summary>
		[DisplayName("App Module Component")]
		[AttributeLogicalName("appmodulecomponentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("appmodulecomponentid", value); }
		}

							/// <summary>
        /// appmodulecomponentidunique
        /// </summary>
		[DisplayName("Application Component Unique Id")]
		[AttributeLogicalName("appmodulecomponentidunique")]
		public Guid ApplicationComponentUniqueId
		{	
			get { return GetAttributeValue<Guid>("appmodulecomponentidunique"); }
			set
			{ 
				if(value == ApplicationComponentUniqueId) return;
				SetAttributeValue("appmodulecomponentidunique", value);
			}
		}	
			
		/// <summary>
        /// appmoduleidname
        /// </summary>
		[DisplayName("appmoduleidname")]
		[AttributeLogicalName("appmoduleidname")]
		public string Appmoduleidname
		{	
			get { return GetAttributeValue<string>("appmoduleidname"); }
			set
			{ 
				if(value == Appmoduleidname) return;
				SetAttributeValue("appmoduleidname", value);
			}
		}	
			
		/// <summary>
        /// appmoduleidunique
        /// </summary>
		[DisplayName("AppModule")]
		[AttributeLogicalName("appmoduleidunique")]
		public EntityReference AppModule
		{	
			get { return GetAttributeValue<EntityReference>("appmoduleidunique"); }
			set
			{ 
				if(value == AppModule) return;
				SetAttributeValue("appmoduleidunique", value);
			}
		}	
			
		/// <summary>
        /// componenttype
        /// </summary>
		[DisplayName("Object Type Code")]
		[AttributeLogicalName("componenttype")]
		public eComponentType? ObjectTypeCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componenttype");
				if (optionSetValue != null) return (eComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ObjectTypeCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componenttype", optionSetValue); 
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
        /// exchangerate
        /// </summary>
		[DisplayName("ExchangeRate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
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
        /// isdefault
        /// </summary>
		[DisplayName("Is Default")]
		[AttributeLogicalName("isdefault")]
		public bool? IsDefault
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == IsDefault) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// ismetadata
        /// </summary>
		[DisplayName("Is Metadata")]
		[AttributeLogicalName("ismetadata")]
		public bool? IsMetadata
		{	
			get { return GetAttributeValue<bool?>("ismetadata"); }
			set
			{ 
				if(value == IsMetadata) return;
				SetAttributeValue("ismetadata", value);
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
        /// objectid
        /// </summary>
		[DisplayName("Object")]
		[AttributeLogicalName("objectid")]
		public Guid ObjectId
		{	
			get { return GetAttributeValue<Guid>("objectid"); }
			set
			{ 
				if(value == ObjectId) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// overwritetime
        /// </summary>
		[DisplayName("Created On")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? CreatedOn2
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == CreatedOn2) return;
				SetAttributeValue("overwritetime", value);
			}
		}	
			
		/// <summary>
        /// rootappmodulecomponentid
        /// </summary>
		[DisplayName("Root App Module Component")]
		[AttributeLogicalName("rootappmodulecomponentid")]
		public Guid RootAppModuleComponentId
		{	
			get { return GetAttributeValue<Guid>("rootappmodulecomponentid"); }
			set
			{ 
				if(value == RootAppModuleComponentId) return;
				SetAttributeValue("rootappmodulecomponentid", value);
			}
		}	
			
		/// <summary>
        /// rootcomponentbehavior
        /// </summary>
		[DisplayName("Root Component Behavior")]
		[AttributeLogicalName("rootcomponentbehavior")]
		public eIncludeBehavior? RootComponentBehavior
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("rootcomponentbehavior");
				if (optionSetValue != null) return (eIncludeBehavior)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RootComponentBehavior) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("rootcomponentbehavior", optionSetValue); 
			}
		}

		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("Time Zone Rule Version Number")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? TimeZoneRuleVersionNumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == TimeZoneRuleVersionNumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("UTC Conversion Time Zone Code")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? UTCConversionTimeZoneCode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == UTCConversionTimeZoneCode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
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
		public enum eComponentType
		{	
		
			[Label("Entities")]
			[Description(@"")]
			Entities = 1, 
		
			[Label("Views")]
			[Description(@"")]
			Views = 26, 
		
			[Label("Business Process Flows")]
			[Description(@"")]
			BusinessProcessFlows = 29, 
		
			[Label("Command (Ribbon) for Forms, Grids, sub grids")]
			[Description(@"")]
			CommandRibbonForFormsGridsSubGrids = 48, 
		
			[Label("Charts")]
			[Description(@"")]
			Charts = 59, 
		
			[Label("Forms")]
			[Description(@"")]
			Forms = 60, 
		
			[Label("Sitemap")]
			[Description(@"")]
			Sitemap = 62, 
		}
		
		public enum eIncludeBehavior
		{	
		
			[Label("Include Subcomponents")]
			[Description(@"")]
			IncludeSubcomponents = 0, 
		
			[Label("Do not include subcomponents")]
			[Description(@"")]
			DoNotIncludeSubcomponents = 1, 
		
			[Label("Include As Shell Only")]
			[Description(@"")]
			IncludeAsShellOnly = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>appmodulecomponentid</summary>
			public const string AppModuleComponentId = "appmodulecomponentid";

			/// <summary>appmodulecomponentidunique</summary>
			public const string ApplicationComponentUniqueId = "appmodulecomponentidunique";

			/// <summary>appmoduleidname</summary>
			public const string Appmoduleidname = "appmoduleidname";

			/// <summary>appmoduleidunique</summary>
			public const string AppModule = "appmoduleidunique";

			/// <summary>componenttype</summary>
			public const string ObjectTypeCode = "componenttype";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isdefault</summary>
			public const string IsDefault = "isdefault";

			/// <summary>ismetadata</summary>
			public const string IsMetadata = "ismetadata";

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

			/// <summary>objectid</summary>
			public const string ObjectId = "objectid";

			/// <summary>overwritetime</summary>
			public const string CreatedOn2 = "overwritetime";

			/// <summary>rootappmodulecomponentid</summary>
			public const string RootAppModuleComponentId = "rootappmodulecomponentid";

			/// <summary>rootcomponentbehavior</summary>
			public const string RootComponentBehavior = "rootcomponentbehavior";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

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

