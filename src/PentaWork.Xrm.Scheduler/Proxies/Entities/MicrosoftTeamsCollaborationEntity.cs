using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{CollaborationTeamName}")] 	
	[EntityLogicalName("msdyn_teamscollaboration")]
	public sealed class MicrosoftTeamsCollaborationEntity : Entity
	{	
		public static readonly int? EntityTypeCode = 10109;
		public new const string LogicalName = "msdyn_teamscollaboration";
		public const string PrimaryIdAttribute = "msdyn_teamscollaborationid";
		public const string PrimaryNameAttribute = "msdyn_teamname";
	
		public MicrosoftTeamsCollaborationEntity() : base("msdyn_teamscollaboration") { }

		#region Attributes
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
        /// msdyn_appid
        /// </summary>
		[DisplayName("Collaboration app id  which was used to pin the record")]
		[AttributeLogicalName("msdyn_appid")]
		public string CollaborationAppIdWhichWasUsedToPinTheRecord
		{	
			get { return GetAttributeValue<string>("msdyn_appid"); }
			set
			{ 
				if(value == CollaborationAppIdWhichWasUsedToPinTheRecord) return;
				SetAttributeValue("msdyn_appid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_channelfolderrelativeurl
        /// </summary>
		[DisplayName("Collaboration Channel Relative Folder URL")]
		[AttributeLogicalName("msdyn_channelfolderrelativeurl")]
		public string CollaborationChannelRelativeFolderURL
		{	
			get { return GetAttributeValue<string>("msdyn_channelfolderrelativeurl"); }
			set
			{ 
				if(value == CollaborationChannelRelativeFolderURL) return;
				SetAttributeValue("msdyn_channelfolderrelativeurl", value);
			}
		}	
			
		/// <summary>
        /// msdyn_channelid
        /// </summary>
		[DisplayName("Collaboration channel ID")]
		[AttributeLogicalName("msdyn_channelid")]
		public string CollaborationChannelID
		{	
			get { return GetAttributeValue<string>("msdyn_channelid"); }
			set
			{ 
				if(value == CollaborationChannelID) return;
				SetAttributeValue("msdyn_channelid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_channelname
        /// </summary>
		[DisplayName("Collaboration Channel Name")]
		[AttributeLogicalName("msdyn_channelname")]
		public string CollaborationChannelName
		{	
			get { return GetAttributeValue<string>("msdyn_channelname"); }
			set
			{ 
				if(value == CollaborationChannelName) return;
				SetAttributeValue("msdyn_channelname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_channeltype
        /// </summary>
		[DisplayName("Collaboration Channel Type(Private, etc)")]
		[AttributeLogicalName("msdyn_channeltype")]
		public string CollaborationChannelTypePrivateEtc
		{	
			get { return GetAttributeValue<string>("msdyn_channeltype"); }
			set
			{ 
				if(value == CollaborationChannelTypePrivateEtc) return;
				SetAttributeValue("msdyn_channeltype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_contenturl
        /// </summary>
		[DisplayName("Collaboration tab content url")]
		[AttributeLogicalName("msdyn_contenturl")]
		public string CollaborationTabContentUrl
		{	
			get { return GetAttributeValue<string>("msdyn_contenturl"); }
			set
			{ 
				if(value == CollaborationTabContentUrl) return;
				SetAttributeValue("msdyn_contenturl", value);
			}
		}	
			
		/// <summary>
        /// msdyn_groupid
        /// </summary>
		[DisplayName("Collaboration Group Identifier")]
		[AttributeLogicalName("msdyn_groupid")]
		public Guid CollaborationGroupIdentifierId
		{	
			get { return GetAttributeValue<Guid>("msdyn_groupid"); }
			set
			{ 
				if(value == CollaborationGroupIdentifierId) return;
				SetAttributeValue("msdyn_groupid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_pipedentityid
        /// </summary>
		[DisplayName("Collaboration piped entity id  which was used to pin the record")]
		[AttributeLogicalName("msdyn_pipedentityid")]
		public string CollaborationPipedEntityIdWhichWasUsedToPinTheRecord
		{	
			get { return GetAttributeValue<string>("msdyn_pipedentityid"); }
			set
			{ 
				if(value == CollaborationPipedEntityIdWhichWasUsedToPinTheRecord) return;
				SetAttributeValue("msdyn_pipedentityid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_teamid
        /// </summary>
		[DisplayName("Collaboration Team ID")]
		[AttributeLogicalName("msdyn_teamid")]
		public string CollaborationTeamID
		{	
			get { return GetAttributeValue<string>("msdyn_teamid"); }
			set
			{ 
				if(value == CollaborationTeamID) return;
				SetAttributeValue("msdyn_teamid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_teamname
        /// </summary>
		[DisplayName("Collaboration Team Name")]
		[AttributeLogicalName("msdyn_teamname")]
		public string CollaborationTeamName
		{	
			get { return GetAttributeValue<string>("msdyn_teamname"); }
			set
			{ 
				if(value == CollaborationTeamName) return;
				SetAttributeValue("msdyn_teamname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_teamscollaborationid
        /// </summary>
		[DisplayName("Teams Collaboration Identifier")]
		[AttributeLogicalName("msdyn_teamscollaborationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_teamscollaborationid", value); }
		}

							/// <summary>
        /// msdyn_teamsiteurl
        /// </summary>
		[DisplayName("Team Site URL")]
		[AttributeLogicalName("msdyn_teamsiteurl")]
		public string TeamSiteURL
		{	
			get { return GetAttributeValue<string>("msdyn_teamsiteurl"); }
			set
			{ 
				if(value == TeamSiteURL) return;
				SetAttributeValue("msdyn_teamsiteurl", value);
			}
		}	
			
		/// <summary>
        /// msdyn_tenantid
        /// </summary>
		[DisplayName("Collaboration Tenant Identifier")]
		[AttributeLogicalName("msdyn_tenantid")]
		public Guid CollaborationTenantIdentifierId
		{	
			get { return GetAttributeValue<Guid>("msdyn_tenantid"); }
			set
			{ 
				if(value == CollaborationTenantIdentifierId) return;
				SetAttributeValue("msdyn_tenantid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_weburl
        /// </summary>
		[DisplayName("Collaboration tab web url")]
		[AttributeLogicalName("msdyn_weburl")]
		public string CollaborationTabWebUrl
		{	
			get { return GetAttributeValue<string>("msdyn_weburl"); }
			set
			{ 
				if(value == CollaborationTabWebUrl) return;
				SetAttributeValue("msdyn_weburl", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization ID")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationID
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationID) return;
				SetAttributeValue("organizationid", value);
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
        /// regardingobjectid
        /// </summary>
		[DisplayName("Related Dynamics 365 Record ID")]
		[AttributeLogicalName("regardingobjectid")]
		public Guid RelatedDynamics365RecordId
		{	
			get { return GetAttributeValue<Guid>("regardingobjectid"); }
			set
			{ 
				if(value == RelatedDynamics365RecordId) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("Related Dynamics 365 Record ID (Entity Code)")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public int? RelatedDynamics365RecordIDEntityCode
		{	
			get { return GetAttributeValue<int?>("regardingobjecttypecode"); }
			set
			{ 
				if(value == RelatedDynamics365RecordIDEntityCode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypename
        /// </summary>
		[DisplayName("Related Dynamics 365 Record Type Name")]
		[AttributeLogicalName("regardingobjecttypename")]
		public string RelatedDynamics365RecordTypeName
		{	
			get { return GetAttributeValue<string>("regardingobjecttypename"); }
			set
			{ 
				if(value == RelatedDynamics365RecordTypeName) return;
				SetAttributeValue("regardingobjecttypename", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
			}
		}

		/// <summary>
        /// statuscode
        /// </summary>
		[DisplayName("Status Reason")]
		[AttributeLogicalName("statuscode")]
		public eStatusReason? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusReason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
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
        /// 1:N Get entities for 'msdyn_teamscollaboration_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_teamscollaboration_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynTeamscollaborationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_teamscollaboration_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_teamscollaboration_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_teamscollaboration_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_teamscollaboration_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynTeamscollaborationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_teamscollaboration_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_teamscollaboration_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_teamscollaboration_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_teamscollaboration_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynTeamscollaborationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_teamscollaboration_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_teamscollaboration_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_teamscollaboration_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_teamscollaboration_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynTeamscollaborationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_teamscollaboration_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_teamscollaboration_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_teamscollaboration_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_teamscollaboration_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynTeamscollaborationProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_teamscollaboration_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_teamscollaboration_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_teamscollaboration_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_teamscollaboration_SyncErrors")]
		public IEnumerable<SyncError> MsdynTeamscollaborationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_teamscollaboration_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_teamscollaboration_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>msdyn_appid</summary>
			public const string CollaborationAppIdWhichWasUsedToPinTheRecord = "msdyn_appid";

			/// <summary>msdyn_channelfolderrelativeurl</summary>
			public const string CollaborationChannelRelativeFolderURL = "msdyn_channelfolderrelativeurl";

			/// <summary>msdyn_channelid</summary>
			public const string CollaborationChannelID = "msdyn_channelid";

			/// <summary>msdyn_channelname</summary>
			public const string CollaborationChannelName = "msdyn_channelname";

			/// <summary>msdyn_channeltype</summary>
			public const string CollaborationChannelTypePrivateEtc = "msdyn_channeltype";

			/// <summary>msdyn_contenturl</summary>
			public const string CollaborationTabContentUrl = "msdyn_contenturl";

			/// <summary>msdyn_groupid</summary>
			public const string CollaborationGroupIdentifierId = "msdyn_groupid";

			/// <summary>msdyn_pipedentityid</summary>
			public const string CollaborationPipedEntityIdWhichWasUsedToPinTheRecord = "msdyn_pipedentityid";

			/// <summary>msdyn_teamid</summary>
			public const string CollaborationTeamID = "msdyn_teamid";

			/// <summary>msdyn_teamname</summary>
			public const string CollaborationTeamName = "msdyn_teamname";

			/// <summary>msdyn_teamscollaborationid</summary>
			public const string TeamsCollaborationIdentifierId = "msdyn_teamscollaborationid";

			/// <summary>msdyn_teamsiteurl</summary>
			public const string TeamSiteURL = "msdyn_teamsiteurl";

			/// <summary>msdyn_tenantid</summary>
			public const string CollaborationTenantIdentifierId = "msdyn_tenantid";

			/// <summary>msdyn_weburl</summary>
			public const string CollaborationTabWebUrl = "msdyn_weburl";

			/// <summary>organizationid</summary>
			public const string OrganizationID = "organizationid";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>regardingobjectid</summary>
			public const string RelatedDynamics365RecordId = "regardingobjectid";

			/// <summary>regardingobjecttypecode</summary>
			public const string RelatedDynamics365RecordIDEntityCode = "regardingobjecttypecode";

			/// <summary>regardingobjecttypename</summary>
			public const string RelatedDynamics365RecordTypeName = "regardingobjecttypename";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

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
			/// <summary>1:N msdyn_teamscollaboration_AsyncOperations</summary>
			public const string MsdynTeamscollaborationAsyncOperations = "msdyn_teamscollaboration_AsyncOperations";

			/// <summary>1:N msdyn_teamscollaboration_BulkDeleteFailures</summary>
			public const string MsdynTeamscollaborationBulkDeleteFailures = "msdyn_teamscollaboration_BulkDeleteFailures";

			/// <summary>1:N msdyn_teamscollaboration_MailboxTrackingFolders</summary>
			public const string MsdynTeamscollaborationMailboxTrackingFolders = "msdyn_teamscollaboration_MailboxTrackingFolders";

			/// <summary>1:N msdyn_teamscollaboration_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynTeamscollaborationPrincipalObjectAttributeAccesses = "msdyn_teamscollaboration_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_teamscollaboration_ProcessSession</summary>
			public const string MsdynTeamscollaborationProcessSession = "msdyn_teamscollaboration_ProcessSession";

			/// <summary>1:N msdyn_teamscollaboration_SyncErrors</summary>
			public const string MsdynTeamscollaborationSyncErrors = "msdyn_teamscollaboration_SyncErrors";

		}
		#endregion
	}
}

