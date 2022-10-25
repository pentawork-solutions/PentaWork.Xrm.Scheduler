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
	[EntityLogicalName("mobileofflineprofileitemassociation")]
	public sealed class MobileOfflineProfileItemAssociation : Entity
	{	
		public static readonly int? EntityTypeCode = 9868;
		public new const string LogicalName = "mobileofflineprofileitemassociation";
		public const string PrimaryIdAttribute = "mobileofflineprofileitemassociationid";
		public const string PrimaryNameAttribute = "name";
	
		public MobileOfflineProfileItemAssociation() : base("mobileofflineprofileitemassociation") { }

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
        /// isvalidated
        /// </summary>
		[DisplayName("Is Valid For Mobile Offline")]
		[AttributeLogicalName("isvalidated")]
		public bool? IsValidForMobileOffline
		{	
			get { return GetAttributeValue<bool?>("isvalidated"); }
			set
			{ 
				if(value == IsValidForMobileOffline) return;
				SetAttributeValue("isvalidated", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineprofileitemassociationid
        /// </summary>
		[DisplayName("Mobile Offline profileitemassociation")]
		[AttributeLogicalName("mobileofflineprofileitemassociationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("mobileofflineprofileitemassociationid", value); }
		}

							/// <summary>
        /// mobileofflineprofileitemassociationidunique
        /// </summary>
		[DisplayName("Unique Id")]
		[AttributeLogicalName("mobileofflineprofileitemassociationidunique")]
		public Guid UniqueId
		{	
			get { return GetAttributeValue<Guid>("mobileofflineprofileitemassociationidunique"); }
			set
			{ 
				if(value == UniqueId) return;
				SetAttributeValue("mobileofflineprofileitemassociationidunique", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineprofileitemid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("mobileofflineprofileitemid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("mobileofflineprofileitemid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("mobileofflineprofileitemid", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineprofileitemidname
        /// </summary>
		[DisplayName("mobileofflineprofileitemidname")]
		[AttributeLogicalName("mobileofflineprofileitemidname")]
		public string Mobileofflineprofileitemidname
		{	
			get { return GetAttributeValue<string>("mobileofflineprofileitemidname"); }
			set
			{ 
				if(value == Mobileofflineprofileitemidname) return;
				SetAttributeValue("mobileofflineprofileitemidname", value);
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
        /// processid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// profileitemassociationentityfilter
        /// </summary>
		[DisplayName("Profile item association entity filter")]
		[AttributeLogicalName("profileitemassociationentityfilter")]
		public string ProfileItemAssociationEntityFilter
		{	
			get { return GetAttributeValue<string>("profileitemassociationentityfilter"); }
			set
			{ 
				if(value == ProfileItemAssociationEntityFilter) return;
				SetAttributeValue("profileitemassociationentityfilter", value);
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
        /// relationshipdata
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("relationshipdata")]
		public string InternalUseOnly
		{	
			get { return GetAttributeValue<string>("relationshipdata"); }
			set
			{ 
				if(value == InternalUseOnly) return;
				SetAttributeValue("relationshipdata", value);
			}
		}	
			
		/// <summary>
        /// relationshipdisplayname
        /// </summary>
		[DisplayName("Entity Relationship")]
		[AttributeLogicalName("relationshipdisplayname")]
		public string EntityRelationship
		{	
			get { return GetAttributeValue<string>("relationshipdisplayname"); }
			set
			{ 
				if(value == EntityRelationship) return;
				SetAttributeValue("relationshipdisplayname", value);
			}
		}	
			
		/// <summary>
        /// relationshipid
        /// </summary>
		[DisplayName("Shows the relationship")]
		[AttributeLogicalName("relationshipid")]
		public Guid ShowsTheRelationshipId
		{	
			get { return GetAttributeValue<Guid>("relationshipid"); }
			set
			{ 
				if(value == ShowsTheRelationshipId) return;
				SetAttributeValue("relationshipid", value);
			}
		}	
			
		/// <summary>
        /// relationshipname
        /// </summary>
		[DisplayName("Entity Relationship")]
		[AttributeLogicalName("relationshipname")]
		public string EntityRelationship2
		{	
			get { return GetAttributeValue<string>("relationshipname"); }
			set
			{ 
				if(value == EntityRelationship2) return;
				SetAttributeValue("relationshipname", value);
			}
		}	
			
		/// <summary>
        /// selectedrelationshipsschema
        /// </summary>
		[DisplayName("Entity Relationship")]
		[AttributeLogicalName("selectedrelationshipsschema")]
		public egSelectedMobileOfflineEnabledEntitiesRelationships? EntityRelationship3
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("selectedrelationshipsschema");
				if (optionSetValue != null) return (egSelectedMobileOfflineEnabledEntitiesRelationships)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EntityRelationship3) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("selectedrelationshipsschema", optionSetValue); 
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
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Process Stage")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedProcessStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedProcessStageId) return;
				SetAttributeValue("stageid", value);
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
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
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
		
		public enum egSelectedMobileOfflineEnabledEntitiesRelationships
		{	
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isvalidated</summary>
			public const string IsValidForMobileOffline = "isvalidated";

			/// <summary>mobileofflineprofileitemassociationid</summary>
			public const string MobileOfflineProfileitemassociationId = "mobileofflineprofileitemassociationid";

			/// <summary>mobileofflineprofileitemassociationidunique</summary>
			public const string UniqueId = "mobileofflineprofileitemassociationidunique";

			/// <summary>mobileofflineprofileitemid</summary>
			public const string Regarding = "mobileofflineprofileitemid";

			/// <summary>mobileofflineprofileitemidname</summary>
			public const string Mobileofflineprofileitemidname = "mobileofflineprofileitemidname";

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

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>profileitemassociationentityfilter</summary>
			public const string ProfileItemAssociationEntityFilter = "profileitemassociationentityfilter";

			/// <summary>publishedon</summary>
			public const string PublishedOn = "publishedon";

			/// <summary>relationshipdata</summary>
			public const string InternalUseOnly = "relationshipdata";

			/// <summary>relationshipdisplayname</summary>
			public const string EntityRelationship = "relationshipdisplayname";

			/// <summary>relationshipid</summary>
			public const string ShowsTheRelationshipId = "relationshipid";

			/// <summary>relationshipname</summary>
			public const string EntityRelationship2 = "relationshipname";

			/// <summary>selectedrelationshipsschema</summary>
			public const string EntityRelationship3 = "selectedrelationshipsschema";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

