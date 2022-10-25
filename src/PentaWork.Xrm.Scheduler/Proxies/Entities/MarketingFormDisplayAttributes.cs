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
	[EntityLogicalName("marketingformdisplayattributes")]
	public sealed class MarketingFormDisplayAttributes : Entity
	{	
		public static readonly int? EntityTypeCode = 10142;
		public new const string LogicalName = "marketingformdisplayattributes";
		public const string PrimaryIdAttribute = "marketingformdisplayattributesid";
		public const string PrimaryNameAttribute = "name";
	
		public MarketingFormDisplayAttributes() : base("marketingformdisplayattributes") { }

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
        /// displayattributelist
        /// </summary>
		[DisplayName("Display Attributes List")]
		[AttributeLogicalName("displayattributelist")]
		public string DisplayAttributesList
		{	
			get { return GetAttributeValue<string>("displayattributelist"); }
			set
			{ 
				if(value == DisplayAttributesList) return;
				SetAttributeValue("displayattributelist", value);
			}
		}	
			
		/// <summary>
        /// entitylogicalname
        /// </summary>
		[DisplayName("Entity Name")]
		[AttributeLogicalName("entitylogicalname")]
		public string EntityName
		{	
			get { return GetAttributeValue<string>("entitylogicalname"); }
			set
			{ 
				if(value == EntityName) return;
				SetAttributeValue("entitylogicalname", value);
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
        /// marketingformdisplayattributesid
        /// </summary>
		[DisplayName("Marketing form display attributes ID")]
		[AttributeLogicalName("marketingformdisplayattributesid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("marketingformdisplayattributesid", value); }
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
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// 1:N Get entities for 'marketingformdisplayattributes_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_AsyncOperations")]
		public IEnumerable<SystemJob> MarketingformdisplayattributesAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("marketingformdisplayattributes_AsyncOperations", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MarketingformdisplayattributesBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("marketingformdisplayattributes_BulkDeleteFailures", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MarketingformdisplayattributesDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("marketingformdisplayattributes_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MarketingformdisplayattributesDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("marketingformdisplayattributes_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MarketingformdisplayattributesMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("marketingformdisplayattributes_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MarketingformdisplayattributesPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("marketingformdisplayattributes_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_ProcessSession")]
		public IEnumerable<ProcessSession> MarketingformdisplayattributesProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("marketingformdisplayattributes_ProcessSession", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'marketingformdisplayattributes_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("marketingformdisplayattributes_SyncErrors")]
		public IEnumerable<SyncError> MarketingformdisplayattributesSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("marketingformdisplayattributes_SyncErrors", null); }
			set { SetRelatedEntities("marketingformdisplayattributes_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Saved")]
			[Description(@"")]
			Saved_Active = 1, 
		
			[Label("Published")]
			[Description(@"")]
			Published_Inactive = 2, 
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

			/// <summary>displayattributelist</summary>
			public const string DisplayAttributesList = "displayattributelist";

			/// <summary>entitylogicalname</summary>
			public const string EntityName = "entitylogicalname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>marketingformdisplayattributesid</summary>
			public const string MarketingFormDisplayAttributesId = "marketingformdisplayattributesid";

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
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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
			/// <summary>1:N marketingformdisplayattributes_AsyncOperations</summary>
			public const string MarketingformdisplayattributesAsyncOperations = "marketingformdisplayattributes_AsyncOperations";

			/// <summary>1:N marketingformdisplayattributes_BulkDeleteFailures</summary>
			public const string MarketingformdisplayattributesBulkDeleteFailures = "marketingformdisplayattributes_BulkDeleteFailures";

			/// <summary>1:N marketingformdisplayattributes_DuplicateBaseRecord</summary>
			public const string MarketingformdisplayattributesDuplicateBaseRecord = "marketingformdisplayattributes_DuplicateBaseRecord";

			/// <summary>1:N marketingformdisplayattributes_DuplicateMatchingRecord</summary>
			public const string MarketingformdisplayattributesDuplicateMatchingRecord = "marketingformdisplayattributes_DuplicateMatchingRecord";

			/// <summary>1:N marketingformdisplayattributes_MailboxTrackingFolders</summary>
			public const string MarketingformdisplayattributesMailboxTrackingFolders = "marketingformdisplayattributes_MailboxTrackingFolders";

			/// <summary>1:N marketingformdisplayattributes_PrincipalObjectAttributeAccesses</summary>
			public const string MarketingformdisplayattributesPrincipalObjectAttributeAccesses = "marketingformdisplayattributes_PrincipalObjectAttributeAccesses";

			/// <summary>1:N marketingformdisplayattributes_ProcessSession</summary>
			public const string MarketingformdisplayattributesProcessSession = "marketingformdisplayattributes_ProcessSession";

			/// <summary>1:N marketingformdisplayattributes_SyncErrors</summary>
			public const string MarketingformdisplayattributesSyncErrors = "marketingformdisplayattributes_SyncErrors";

		}
		#endregion
	}
}

