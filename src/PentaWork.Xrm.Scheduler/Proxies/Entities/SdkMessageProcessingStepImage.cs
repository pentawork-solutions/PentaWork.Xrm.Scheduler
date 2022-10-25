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
	[EntityLogicalName("sdkmessageprocessingstepimage")]
	public sealed class SdkMessageProcessingStepImage : Entity
	{	
		public static readonly int? EntityTypeCode = 4615;
		public new const string LogicalName = "sdkmessageprocessingstepimage";
		public const string PrimaryIdAttribute = "sdkmessageprocessingstepimageid";
		public const string PrimaryNameAttribute = "name";
	
		public SdkMessageProcessingStepImage() : base("sdkmessageprocessingstepimage") { }

		#region Attributes
		/// <summary>
        /// attributes
        /// </summary>
		[DisplayName("Attributes")]
		[AttributeLogicalName("attributes")]
		public string Attributes
		{	
			get { return GetAttributeValue<string>("attributes"); }
			set
			{ 
				if(value == Attributes) return;
				SetAttributeValue("attributes", value);
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
        /// entityalias
        /// </summary>
		[DisplayName("Entity Alias")]
		[AttributeLogicalName("entityalias")]
		public string EntityAlias
		{	
			get { return GetAttributeValue<string>("entityalias"); }
			set
			{ 
				if(value == EntityAlias) return;
				SetAttributeValue("entityalias", value);
			}
		}	
			
		/// <summary>
        /// imagetype
        /// </summary>
		[DisplayName("Image Type")]
		[AttributeLogicalName("imagetype")]
		public eImageType? ImageType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("imagetype");
				if (optionSetValue != null) return (eImageType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ImageType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("imagetype", optionSetValue); 
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
		[DisplayName("ismanaged")]
		[AttributeLogicalName("ismanaged")]
		public bool? Ismanaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == Ismanaged) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// messagepropertyname
        /// </summary>
		[DisplayName("Message Property Name")]
		[AttributeLogicalName("messagepropertyname")]
		public string MessagePropertyName
		{	
			get { return GetAttributeValue<string>("messagepropertyname"); }
			set
			{ 
				if(value == MessagePropertyName) return;
				SetAttributeValue("messagepropertyname", value);
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
		[DisplayName("Modified By")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? ModifiedBy2
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == ModifiedBy2) return;
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
        /// relatedattributename
        /// </summary>
		[DisplayName("Related Attribute Name")]
		[AttributeLogicalName("relatedattributename")]
		public string RelatedAttributeName
		{	
			get { return GetAttributeValue<string>("relatedattributename"); }
			set
			{ 
				if(value == RelatedAttributeName) return;
				SetAttributeValue("relatedattributename", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageprocessingstepid
        /// </summary>
		[DisplayName("SDK Message Processing Step")]
		[AttributeLogicalName("sdkmessageprocessingstepid")]
		public EntityReference SDKMessageProcessingStep
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessageprocessingstepid"); }
			set
			{ 
				if(value == SDKMessageProcessingStep) return;
				SetAttributeValue("sdkmessageprocessingstepid", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageprocessingstepimageid
        /// </summary>
		[DisplayName("sdkmessageprocessingstepimageid")]
		[AttributeLogicalName("sdkmessageprocessingstepimageid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("sdkmessageprocessingstepimageid", value); }
		}

							/// <summary>
        /// sdkmessageprocessingstepimageidunique
        /// </summary>
		[DisplayName("sdkmessageprocessingstepimageidunique")]
		[AttributeLogicalName("sdkmessageprocessingstepimageidunique")]
		public Guid SdkmessageprocessingstepimageiduniqueId
		{	
			get { return GetAttributeValue<Guid>("sdkmessageprocessingstepimageidunique"); }
			set
			{ 
				if(value == SdkmessageprocessingstepimageiduniqueId) return;
				SetAttributeValue("sdkmessageprocessingstepimageidunique", value);
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
		
		public enum eImageType
		{	
		
			[Label("PreImage")]
			[Description(@"")]
			PreImage = 0, 
		
			[Label("PostImage")]
			[Description(@"")]
			PostImage = 1, 
		
			[Label("Both")]
			[Description(@"")]
			Both = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>attributes</summary>
			public const string Attributes = "attributes";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>entityalias</summary>
			public const string EntityAlias = "entityalias";

			/// <summary>imagetype</summary>
			public const string ImageType = "imagetype";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string Ismanaged = "ismanaged";

			/// <summary>messagepropertyname</summary>
			public const string MessagePropertyName = "messagepropertyname";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedon</summary>
			public const string ModifiedBy2 = "modifiedon";

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

			/// <summary>relatedattributename</summary>
			public const string RelatedAttributeName = "relatedattributename";

			/// <summary>sdkmessageprocessingstepid</summary>
			public const string SDKMessageProcessingStep = "sdkmessageprocessingstepid";

			/// <summary>sdkmessageprocessingstepimageid</summary>
			public const string SdkmessageprocessingstepimageId = "sdkmessageprocessingstepimageid";

			/// <summary>sdkmessageprocessingstepimageidunique</summary>
			public const string SdkmessageprocessingstepimageiduniqueId = "sdkmessageprocessingstepimageidunique";

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
		}
		#endregion
	}
}

