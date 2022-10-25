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
	[EntityLogicalName("sdkmessagefilter")]
	public sealed class SdkMessageFilter : Entity
	{	
		public static readonly int? EntityTypeCode = 4607;
		public new const string LogicalName = "sdkmessagefilter";
		public const string PrimaryIdAttribute = "sdkmessagefilterid";
		public const string PrimaryNameAttribute = "name";
	
		public SdkMessageFilter() : base("sdkmessagefilter") { }

		#region Attributes
		/// <summary>
        /// availability
        /// </summary>
		[DisplayName("Availability")]
		[AttributeLogicalName("availability")]
		public int? Availability
		{	
			get { return GetAttributeValue<int?>("availability"); }
			set
			{ 
				if(value == Availability) return;
				SetAttributeValue("availability", value);
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
        /// customizationlevel
        /// </summary>
		[DisplayName("customizationlevel")]
		[AttributeLogicalName("customizationlevel")]
		public int? Customizationlevel
		{	
			get { return GetAttributeValue<int?>("customizationlevel"); }
			set
			{ 
				if(value == Customizationlevel) return;
				SetAttributeValue("customizationlevel", value);
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
        /// iscustomprocessingstepallowed
        /// </summary>
		[DisplayName("Custom Processing Step Allowed")]
		[AttributeLogicalName("iscustomprocessingstepallowed")]
		public bool? CustomProcessingStepAllowed
		{	
			get { return GetAttributeValue<bool?>("iscustomprocessingstepallowed"); }
			set
			{ 
				if(value == CustomProcessingStepAllowed) return;
				SetAttributeValue("iscustomprocessingstepallowed", value);
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
        /// isvisible
        /// </summary>
		[DisplayName("isvisible")]
		[AttributeLogicalName("isvisible")]
		public bool? Isvisible
		{	
			get { return GetAttributeValue<bool?>("isvisible"); }
			set
			{ 
				if(value == Isvisible) return;
				SetAttributeValue("isvisible", value);
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
        /// primaryobjecttypecode
        /// </summary>
		[DisplayName("Primary Object Type Code")]
		[AttributeLogicalName("primaryobjecttypecode")]
		public string PrimaryObjectTypeCode
		{	
			get { return GetAttributeValue<string>("primaryobjecttypecode"); }
			set
			{ 
				if(value == PrimaryObjectTypeCode) return;
				SetAttributeValue("primaryobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// restrictionlevel
        /// </summary>
		[DisplayName("restrictionlevel")]
		[AttributeLogicalName("restrictionlevel")]
		public int? Restrictionlevel
		{	
			get { return GetAttributeValue<int?>("restrictionlevel"); }
			set
			{ 
				if(value == Restrictionlevel) return;
				SetAttributeValue("restrictionlevel", value);
			}
		}	
			
		/// <summary>
        /// sdkmessagefilterid
        /// </summary>
		[DisplayName("sdkmessagefilterid")]
		[AttributeLogicalName("sdkmessagefilterid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("sdkmessagefilterid", value); }
		}

							/// <summary>
        /// sdkmessagefilteridunique
        /// </summary>
		[DisplayName("sdkmessagefilteridunique")]
		[AttributeLogicalName("sdkmessagefilteridunique")]
		public Guid SdkmessagefilteriduniqueId
		{	
			get { return GetAttributeValue<Guid>("sdkmessagefilteridunique"); }
			set
			{ 
				if(value == SdkmessagefilteriduniqueId) return;
				SetAttributeValue("sdkmessagefilteridunique", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageid
        /// </summary>
		[DisplayName("SDK Message ID")]
		[AttributeLogicalName("sdkmessageid")]
		public EntityReference SDKMessageID
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
			set
			{ 
				if(value == SDKMessageID) return;
				SetAttributeValue("sdkmessageid", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageidname
        /// </summary>
		[DisplayName("sdkmessageidname")]
		[AttributeLogicalName("sdkmessageidname")]
		public string Sdkmessageidname
		{	
			get { return GetAttributeValue<string>("sdkmessageidname"); }
			set
			{ 
				if(value == Sdkmessageidname) return;
				SetAttributeValue("sdkmessageidname", value);
			}
		}	
			
		/// <summary>
        /// secondaryobjecttypecode
        /// </summary>
		[DisplayName("Secondary Object Type Code")]
		[AttributeLogicalName("secondaryobjecttypecode")]
		public string SecondaryObjectTypeCode
		{	
			get { return GetAttributeValue<string>("secondaryobjecttypecode"); }
			set
			{ 
				if(value == SecondaryObjectTypeCode) return;
				SetAttributeValue("secondaryobjecttypecode", value);
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
			
		/// <summary>
        /// workflowsdkstepenabled
        /// </summary>
		[DisplayName("WorkflowSdkStepEnabled")]
		[AttributeLogicalName("workflowsdkstepenabled")]
		public bool? WorkflowSdkStepEnabled
		{	
			get { return GetAttributeValue<bool?>("workflowsdkstepenabled"); }
			set
			{ 
				if(value == WorkflowSdkStepEnabled) return;
				SetAttributeValue("workflowsdkstepenabled", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'sdkmessagefilterid_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> SdkmessagefilteridSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("sdkmessagefilterid_sdkmessageprocessingstep", null, value); }
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
			/// <summary>availability</summary>
			public const string Availability = "availability";

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

			/// <summary>customizationlevel</summary>
			public const string Customizationlevel = "customizationlevel";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>iscustomprocessingstepallowed</summary>
			public const string CustomProcessingStepAllowed = "iscustomprocessingstepallowed";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>isvisible</summary>
			public const string Isvisible = "isvisible";

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

			/// <summary>organizationid</summary>
			public const string Organizationid = "organizationid";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>primaryobjecttypecode</summary>
			public const string PrimaryObjectTypeCode = "primaryobjecttypecode";

			/// <summary>restrictionlevel</summary>
			public const string Restrictionlevel = "restrictionlevel";

			/// <summary>sdkmessagefilterid</summary>
			public const string SdkmessagefilterId = "sdkmessagefilterid";

			/// <summary>sdkmessagefilteridunique</summary>
			public const string SdkmessagefilteriduniqueId = "sdkmessagefilteridunique";

			/// <summary>sdkmessageid</summary>
			public const string SDKMessageID = "sdkmessageid";

			/// <summary>sdkmessageidname</summary>
			public const string Sdkmessageidname = "sdkmessageidname";

			/// <summary>secondaryobjecttypecode</summary>
			public const string SecondaryObjectTypeCode = "secondaryobjecttypecode";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>workflowsdkstepenabled</summary>
			public const string WorkflowSdkStepEnabled = "workflowsdkstepenabled";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N sdkmessagefilterid_sdkmessageprocessingstep</summary>
			public const string SdkmessagefilteridSdkmessageprocessingstep = "sdkmessagefilterid_sdkmessageprocessingstep";

		}
		#endregion
	}
}

