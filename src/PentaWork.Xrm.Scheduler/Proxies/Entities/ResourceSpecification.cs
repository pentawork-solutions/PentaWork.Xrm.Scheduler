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
	[EntityLogicalName("resourcespec")]
	public sealed class ResourceSpecification : Entity
	{	
		public static readonly int? EntityTypeCode = 4006;
		public new const string LogicalName = "resourcespec";
		public const string PrimaryIdAttribute = "resourcespecid";
		public const string PrimaryNameAttribute = "name";
	
		public ResourceSpecification() : base("resourcespec") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
			}
		}	
			
		/// <summary>
        /// constraints
        /// </summary>
		[DisplayName("Constraints")]
		[AttributeLogicalName("constraints")]
		public string Constraints
		{	
			get { return GetAttributeValue<string>("constraints"); }
			set
			{ 
				if(value == Constraints) return;
				SetAttributeValue("constraints", value);
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
        /// effortrequired
        /// </summary>
		[DisplayName("Effort Required")]
		[AttributeLogicalName("effortrequired")]
		public double? EffortRequired
		{	
			get { return GetAttributeValue<double?>("effortrequired"); }
			set
			{ 
				if(value == EffortRequired) return;
				SetAttributeValue("effortrequired", value);
			}
		}	
			
		/// <summary>
        /// groupobjectid
        /// </summary>
		[DisplayName("Group Object")]
		[AttributeLogicalName("groupobjectid")]
		public Guid GroupObjectId
		{	
			get { return GetAttributeValue<Guid>("groupobjectid"); }
			set
			{ 
				if(value == GroupObjectId) return;
				SetAttributeValue("groupobjectid", value);
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
        /// objectiveexpression
        /// </summary>
		[DisplayName("Objective Expression")]
		[AttributeLogicalName("objectiveexpression")]
		public string ObjectiveExpression
		{	
			get { return GetAttributeValue<string>("objectiveexpression"); }
			set
			{ 
				if(value == ObjectiveExpression) return;
				SetAttributeValue("objectiveexpression", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Object Type")]
		[AttributeLogicalName("objecttypecode")]
		public string ObjectType
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == ObjectType) return;
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
        /// requiredcount
        /// </summary>
		[DisplayName("Required Count")]
		[AttributeLogicalName("requiredcount")]
		public int? RequiredCount
		{	
			get { return GetAttributeValue<int?>("requiredcount"); }
			set
			{ 
				if(value == RequiredCount) return;
				SetAttributeValue("requiredcount", value);
			}
		}	
			
		/// <summary>
        /// resourcespecid
        /// </summary>
		[DisplayName("Resource Spec")]
		[AttributeLogicalName("resourcespecid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("resourcespecid", value); }
		}

							/// <summary>
        /// samesite
        /// </summary>
		[DisplayName("Same Site")]
		[AttributeLogicalName("samesite")]
		public bool? SameSite
		{	
			get { return GetAttributeValue<bool?>("samesite"); }
			set
			{ 
				if(value == SameSite) return;
				SetAttributeValue("samesite", value);
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
		[DisplayName("Version Number")]
		[AttributeLogicalName("versionnumber")]
		public int? VersionNumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ActivityPartyResourceSpec'
        /// </summary>
		[RelationshipSchemaName("ActivityPartyResourceSpec")]
		public IEnumerable<ActivityParty> ActivityPartyResourceSpec
		{
			get { return GetRelatedEntities<ActivityParty>("ActivityPartyResourceSpec", null); }
			set { SetRelatedEntities("ActivityPartyResourceSpec", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resource_spec_services'
        /// </summary>
		[RelationshipSchemaName("resource_spec_services")]
		public IEnumerable<Service> ResourceSpecServices
		{
			get { return GetRelatedEntities<Service>("resource_spec_services", null); }
			set { SetRelatedEntities("resource_spec_services", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceSpec_Annotation'
        /// </summary>
		[RelationshipSchemaName("ResourceSpec_Annotation")]
		public IEnumerable<Note> ResourceSpecAnnotation
		{
			get { return GetRelatedEntities<Note>("ResourceSpec_Annotation", null); }
			set { SetRelatedEntities("ResourceSpec_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceSpec_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ResourceSpec_AsyncOperations")]
		public IEnumerable<SystemJob> ResourceSpecAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ResourceSpec_AsyncOperations", null); }
			set { SetRelatedEntities("ResourceSpec_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ResourceSpec_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ResourceSpec_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ResourceSpecBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ResourceSpec_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ResourceSpec_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcespec_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("resourcespec_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ResourcespecMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("resourcespec_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("resourcespec_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcespec_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("resourcespec_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ResourcespecPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("resourcespec_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("resourcespec_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcespec_resources'
        /// </summary>
		[RelationshipSchemaName("resourcespec_resources")]
		public IEnumerable<Resource> ResourcespecResources
		{
			get { return GetRelatedEntities<Resource>("resourcespec_resources", null); }
			set { SetRelatedEntities("resourcespec_resources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resourcespec_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("resourcespec_SyncErrors")]
		public IEnumerable<SyncError> ResourcespecSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("resourcespec_SyncErrors", null); }
			set { SetRelatedEntities("resourcespec_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>constraints</summary>
			public const string Constraints = "constraints";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>effortrequired</summary>
			public const string EffortRequired = "effortrequired";

			/// <summary>groupobjectid</summary>
			public const string GroupObjectId = "groupobjectid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>objectiveexpression</summary>
			public const string ObjectiveExpression = "objectiveexpression";

			/// <summary>objecttypecode</summary>
			public const string ObjectType = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>requiredcount</summary>
			public const string RequiredCount = "requiredcount";

			/// <summary>resourcespecid</summary>
			public const string ResourceSpecId = "resourcespecid";

			/// <summary>samesite</summary>
			public const string SameSite = "samesite";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ActivityPartyResourceSpec</summary>
			public const string ActivityPartyResourceSpec = "ActivityPartyResourceSpec";

			/// <summary>1:N resource_spec_services</summary>
			public const string ResourceSpecServices = "resource_spec_services";

			/// <summary>1:N ResourceSpec_Annotation</summary>
			public const string ResourceSpecAnnotation = "ResourceSpec_Annotation";

			/// <summary>1:N ResourceSpec_AsyncOperations</summary>
			public const string ResourceSpecAsyncOperations = "ResourceSpec_AsyncOperations";

			/// <summary>1:N ResourceSpec_BulkDeleteFailures</summary>
			public const string ResourceSpecBulkDeleteFailures = "ResourceSpec_BulkDeleteFailures";

			/// <summary>1:N resourcespec_MailboxTrackingFolders</summary>
			public const string ResourcespecMailboxTrackingFolders = "resourcespec_MailboxTrackingFolders";

			/// <summary>1:N resourcespec_PrincipalObjectAttributeAccesses</summary>
			public const string ResourcespecPrincipalObjectAttributeAccesses = "resourcespec_PrincipalObjectAttributeAccesses";

			/// <summary>1:N resourcespec_resources</summary>
			public const string ResourcespecResources = "resourcespec_resources";

			/// <summary>1:N resourcespec_SyncErrors</summary>
			public const string ResourcespecSyncErrors = "resourcespec_SyncErrors";

		}
		#endregion
	}
}

