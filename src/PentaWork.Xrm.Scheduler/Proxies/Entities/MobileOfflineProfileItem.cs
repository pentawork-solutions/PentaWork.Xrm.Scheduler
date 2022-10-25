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
	[EntityLogicalName("mobileofflineprofileitem")]
	public sealed class MobileOfflineProfileItem : Entity
	{	
		public static readonly int? EntityTypeCode = 9867;
		public new const string LogicalName = "mobileofflineprofileitem";
		public const string PrimaryIdAttribute = "mobileofflineprofileitemid";
		public const string PrimaryNameAttribute = "name";
	
		public MobileOfflineProfileItem() : base("mobileofflineprofileitem") { }

		#region Attributes
		/// <summary>
        /// canbefollowed
        /// </summary>
		[DisplayName("Allow Entity to Follow Relationship")]
		[AttributeLogicalName("canbefollowed")]
		public bool? AllowEntityToFollowRelationship
		{	
			get { return GetAttributeValue<bool?>("canbefollowed"); }
			set
			{ 
				if(value == AllowEntityToFollowRelationship) return;
				SetAttributeValue("canbefollowed", value);
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
        /// entityobjecttypecode
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("entityobjecttypecode")]
		public int? InternalUseOnly
		{	
			get { return GetAttributeValue<int?>("entityobjecttypecode"); }
			set
			{ 
				if(value == InternalUseOnly) return;
				SetAttributeValue("entityobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// getrelatedentityrecords
        /// </summary>
		[DisplayName("Get Related Entities")]
		[AttributeLogicalName("getrelatedentityrecords")]
		public bool? GetRelatedEntities
		{	
			get { return GetAttributeValue<bool?>("getrelatedentityrecords"); }
			set
			{ 
				if(value == GetRelatedEntities) return;
				SetAttributeValue("getrelatedentityrecords", value);
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
        /// isvisibleingrid
        /// </summary>
		[DisplayName("Is Visible In Grid")]
		[AttributeLogicalName("isvisibleingrid")]
		public bool? IsVisibleInGrid
		{	
			get { return GetAttributeValue<bool?>("isvisibleingrid"); }
			set
			{ 
				if(value == IsVisibleInGrid) return;
				SetAttributeValue("isvisibleingrid", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineprofileitemid
        /// </summary>
		[DisplayName("Mobile Offline Profile Item")]
		[AttributeLogicalName("mobileofflineprofileitemid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("mobileofflineprofileitemid", value); }
		}

							/// <summary>
        /// mobileofflineprofileitemidunique
        /// </summary>
		[DisplayName("Unique Id")]
		[AttributeLogicalName("mobileofflineprofileitemidunique")]
		public Guid UniqueId
		{	
			get { return GetAttributeValue<Guid>("mobileofflineprofileitemidunique"); }
			set
			{ 
				if(value == UniqueId) return;
				SetAttributeValue("mobileofflineprofileitemidunique", value);
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
        /// profileitementityfilter
        /// </summary>
		[DisplayName("Profile item entity filter")]
		[AttributeLogicalName("profileitementityfilter")]
		public string ProfileItemEntityFilter
		{	
			get { return GetAttributeValue<string>("profileitementityfilter"); }
			set
			{ 
				if(value == ProfileItemEntityFilter) return;
				SetAttributeValue("profileitementityfilter", value);
			}
		}	
			
		/// <summary>
        /// profileitemrule
        /// </summary>
		[DisplayName("View to sync data to device")]
		[AttributeLogicalName("profileitemrule")]
		public EntityReference ViewToSyncDataToDevice
		{	
			get { return GetAttributeValue<EntityReference>("profileitemrule"); }
			set
			{ 
				if(value == ViewToSyncDataToDevice) return;
				SetAttributeValue("profileitemrule", value);
			}
		}	
			
		/// <summary>
        /// profileitemrulename
        /// </summary>
		[DisplayName("profileitemrulename")]
		[AttributeLogicalName("profileitemrulename")]
		public string Profileitemrulename
		{	
			get { return GetAttributeValue<string>("profileitemrulename"); }
			set
			{ 
				if(value == Profileitemrulename) return;
				SetAttributeValue("profileitemrulename", value);
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
        /// recorddistributioncriteria
        /// </summary>
		[DisplayName("Data Download Filter")]
		[AttributeLogicalName("recorddistributioncriteria")]
		public eTheRulesForRecordDownloadInOffline? DataDownloadFilter
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("recorddistributioncriteria");
				if (optionSetValue != null) return (eTheRulesForRecordDownloadInOffline)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DataDownloadFilter) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("recorddistributioncriteria", optionSetValue); 
			}
		}

		/// <summary>
        /// recordsownedbyme
        /// </summary>
		[DisplayName("Download my records")]
		[AttributeLogicalName("recordsownedbyme")]
		public bool? DownloadMyRecords
		{	
			get { return GetAttributeValue<bool?>("recordsownedbyme"); }
			set
			{ 
				if(value == DownloadMyRecords) return;
				SetAttributeValue("recordsownedbyme", value);
			}
		}	
			
		/// <summary>
        /// recordsownedbymybusinessunit
        /// </summary>
		[DisplayName("Download my business unit's records")]
		[AttributeLogicalName("recordsownedbymybusinessunit")]
		public bool? DownloadMyBusinessUnitsRecords
		{	
			get { return GetAttributeValue<bool?>("recordsownedbymybusinessunit"); }
			set
			{ 
				if(value == DownloadMyBusinessUnitsRecords) return;
				SetAttributeValue("recordsownedbymybusinessunit", value);
			}
		}	
			
		/// <summary>
        /// recordsownedbymyteam
        /// </summary>
		[DisplayName("Download my team's records")]
		[AttributeLogicalName("recordsownedbymyteam")]
		public bool? DownloadMyTeamsRecords
		{	
			get { return GetAttributeValue<bool?>("recordsownedbymyteam"); }
			set
			{ 
				if(value == DownloadMyTeamsRecords) return;
				SetAttributeValue("recordsownedbymyteam", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidname
        /// </summary>
		[DisplayName("regardingobjectidname")]
		[AttributeLogicalName("regardingobjectidname")]
		public string Regardingobjectidname
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == Regardingobjectidname) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// relationshipdata
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("relationshipdata")]
		public string InternalUseOnly2
		{	
			get { return GetAttributeValue<string>("relationshipdata"); }
			set
			{ 
				if(value == InternalUseOnly2) return;
				SetAttributeValue("relationshipdata", value);
			}
		}	
			
		/// <summary>
        /// selectedentitymetadata
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("selectedentitymetadata")]
		public string InternalUseOnly3
		{	
			get { return GetAttributeValue<string>("selectedentitymetadata"); }
			set
			{ 
				if(value == InternalUseOnly3) return;
				SetAttributeValue("selectedentitymetadata", value);
			}
		}	
			
		/// <summary>
        /// selectedentitytypecode
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("selectedentitytypecode")]
		public string Entity
		{	
			get { return GetAttributeValue<string>("selectedentitytypecode"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("selectedentitytypecode", value);
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
			
		/// <summary>
        /// viewquery
        /// </summary>
		[DisplayName("View Query")]
		[AttributeLogicalName("viewquery")]
		public string ViewQuery
		{	
			get { return GetAttributeValue<string>("viewquery"); }
			set
			{ 
				if(value == ViewQuery) return;
				SetAttributeValue("viewquery", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'MobileOfflineProfileItem_MobileOfflineProfileItemAssociation'
        /// </summary>
		[RelationshipSchemaName("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation")]
		public IEnumerable<MobileOfflineProfileItemAssociation> MobileOfflineProfileItemMobileOfflineProfileItemAssociation
		{
			get { return GetRelatedEntities<MobileOfflineProfileItemAssociation>("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation", null); }
			set { SetRelatedEntities("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation", null, value); }
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
		
		public enum eTheRulesForRecordDownloadInOffline
		{	
		
			[Label("Download related data only")]
			[Description(@"")]
			DownloadRelatedDataOnly = 0, 
		
			[Label("All records")]
			[Description(@"")]
			AllRecords = 1, 
		
			[Label("Other data filter")]
			[Description(@"")]
			OtherDataFilter = 2, 
		
			[Label("Custom data filter")]
			[Description(@"")]
			CustomDataFilter = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>canbefollowed</summary>
			public const string AllowEntityToFollowRelationship = "canbefollowed";

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

			/// <summary>entityobjecttypecode</summary>
			public const string InternalUseOnly = "entityobjecttypecode";

			/// <summary>getrelatedentityrecords</summary>
			public const string GetRelatedEntities = "getrelatedentityrecords";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isvalidated</summary>
			public const string IsValidForMobileOffline = "isvalidated";

			/// <summary>isvisibleingrid</summary>
			public const string IsVisibleInGrid = "isvisibleingrid";

			/// <summary>mobileofflineprofileitemid</summary>
			public const string MobileOfflineProfileItemId = "mobileofflineprofileitemid";

			/// <summary>mobileofflineprofileitemidunique</summary>
			public const string UniqueId = "mobileofflineprofileitemidunique";

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

			/// <summary>profileitementityfilter</summary>
			public const string ProfileItemEntityFilter = "profileitementityfilter";

			/// <summary>profileitemrule</summary>
			public const string ViewToSyncDataToDevice = "profileitemrule";

			/// <summary>profileitemrulename</summary>
			public const string Profileitemrulename = "profileitemrulename";

			/// <summary>publishedon</summary>
			public const string PublishedOn = "publishedon";

			/// <summary>recorddistributioncriteria</summary>
			public const string DataDownloadFilter = "recorddistributioncriteria";

			/// <summary>recordsownedbyme</summary>
			public const string DownloadMyRecords = "recordsownedbyme";

			/// <summary>recordsownedbymybusinessunit</summary>
			public const string DownloadMyBusinessUnitsRecords = "recordsownedbymybusinessunit";

			/// <summary>recordsownedbymyteam</summary>
			public const string DownloadMyTeamsRecords = "recordsownedbymyteam";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>relationshipdata</summary>
			public const string InternalUseOnly2 = "relationshipdata";

			/// <summary>selectedentitymetadata</summary>
			public const string InternalUseOnly3 = "selectedentitymetadata";

			/// <summary>selectedentitytypecode</summary>
			public const string Entity = "selectedentitytypecode";

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

			/// <summary>viewquery</summary>
			public const string ViewQuery = "viewquery";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N MobileOfflineProfileItem_MobileOfflineProfileItemAssociation</summary>
			public const string MobileOfflineProfileItemMobileOfflineProfileItemAssociation = "MobileOfflineProfileItem_MobileOfflineProfileItemAssociation";

		}
		#endregion
	}
}

